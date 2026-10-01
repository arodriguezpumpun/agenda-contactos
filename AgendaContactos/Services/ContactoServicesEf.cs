using AgendaContactos.Data;
using AgendaContactos.Models;
namespace AgendaContactos.Services;

public class ContactoServiceEf : IContactoService
{
    private readonly AgendaDbContext _db;
    public ContactoServiceEf(AgendaDbContext db)
    {
        _db = db;
    }
    public IEnumerable<Contacto> ObtenerTodos() =>
    _db.Contactos.OrderBy(c => c.Nombre).ToList();
    public Contacto? ObtenerPorId(int id) => _db.Contactos.Find(id);
    public void Anadir(Contacto contacto)
    {
        _db.Contactos.Add(contacto);
        _db.SaveChanges();
    }

    public void Actualizar(Contacto contacto)
    {
        var existente = _db.Contactos.Find(contacto.Id);
        if (existente is null) return;

        existente.Nombre = contacto.Nombre;
        existente.Telefono = contacto.Telefono;
        existente.Email = contacto.Email;
        _db.SaveChanges();
    }

    public void Borrar(int id)
    {
        var contacto = _db.Contactos.Find(id);
        if (contacto is null) return;

        _db.Contactos.Remove(contacto);
        _db.SaveChanges();
    }
}