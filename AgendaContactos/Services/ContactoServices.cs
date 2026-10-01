using AgendaContactos.Models;

namespace AgendaContactos.Services;

public class ContactoService : IContactoService
{
    private readonly List<Contacto> _contactos = new();
    private readonly object _lock = new();
    private int _siguienteId = 1;

    public ContactoService()
    {
        // Datos de ejemplo para no empezar con la tabla vacía
        Anadir(new Contacto 
        { 
            Nombre = "Ana García", 
            Telefono = "600111222",
            Email = "ana@ejemplo.com" 
        });
        Anadir(new Contacto 
        { 
            Nombre = "Luis Pérez", 
            Telefono = "600333444",
            Email = "luis@ejemplo.com" 
        });
    }

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
            existente.Telefono = contacto.Telefono;
            existente.Email = contacto.Email;
        }
    }

    public void Borrar(int id)
    {
        lock (_lock)
        {
            _contactos.RemoveAll(c => c.Id == id);
        }
    }
}