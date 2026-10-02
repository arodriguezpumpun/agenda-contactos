using AgendaContactos.Models;

namespace AgendaContactos.Services;

public class ContactoService : IContactoService
{
    private readonly List<Contacto> _contactos = new();
    private readonly object _lock = new();
    private int _siguienteId = 1;

    public IEnumerable<Contacto> ObtenerTodos()
    {
        lock (_lock)
        {
            return _contactos.OrderBy(c => c.Nombre).ToList();
        }
    }

    public Contacto? ObtenerPorId(int id)
    {
        lock (_lock)
        {
            return _contactos.FirstOrDefault(c => c.Id == id);
        }
    }

    public void Anadir(Contacto contacto)
    {
        lock (_lock)
        {
            contacto.Id = _siguienteId++;
            _contactos.Add(contacto);
        }
    }

    public void Actualizar(Contacto contacto)
    {
        lock (_lock)
        {
            var existente = _contactos.FirstOrDefault(c => c.Id == contacto.Id);
            if (existente is null) return;

            existente.Nombre = contacto.Nombre;
            existente.Apellidos = contacto.Apellidos;
            existente.Apodo = contacto.Apodo;
            existente.Telefono = contacto.Telefono;
            existente.Email = contacto.Email;
            existente.Favorito = contacto.Favorito;
        }
    }

    public void Borrar(int id)
    {
        lock (_lock)
        {
            _contactos.RemoveAll(c => c.Id == id);
        }
    }

    public void ToggleFavorito(int id)
    {
        lock (_lock)
        {
            var contacto = _contactos.FirstOrDefault(c => c.Id == id);
            if (contacto is null) return;

            contacto.Favorito = !contacto.Favorito;
        }
    }
}