using AgendaContactos.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaContactos.Data;

public class AgendaDbContext : DbContext
{
    public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
        : base(options) { }

    public DbSet<Contacto> Contactos => Set<Contacto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contacto>().HasData(
            new Contacto { Id = 1, Nombre = "Ana García", Telefono = "600111222", Email = "ana@ejemplo.com" },
            new Contacto { Id = 2, Nombre = "Luis Pérez", Telefono = "600333444", Email = "luis@ejemplo.com" },
            new Contacto { Id = 3, Nombre = "María López", Telefono = "600555666", Email = "maria@ejemplo.com" },
            new Contacto { Id = 4, Nombre = "Carlos Ruiz", Telefono = "600777888", Email = "carlos@ejemplo.com" },
            new Contacto { Id = 5, Nombre = "Laura Fernández", Telefono = "600999000", Email = "laura@ejemplo.com" },
            new Contacto { Id = 6, Nombre = "Javier Sánchez", Telefono = "601111222", Email = "javier@ejemplo.com" },
            new Contacto { Id = 7, Nombre = "Elena Martín", Telefono = "601333444", Email = "elena@ejemplo.com" },
            new Contacto { Id = 8, Nombre = "David Gómez", Telefono = "601555666", Email = "david@ejemplo.com" },
            new Contacto { Id = 9, Nombre = "Sara Jiménez", Telefono = "601777888", Email = "sara@ejemplo.com" },
            new Contacto { Id = 10, Nombre = "Pablo Díaz", Telefono = "601999000", Email = "pablo@ejemplo.com" },
            new Contacto { Id = 11, Nombre = "Lucía Torres", Telefono = "602111222", Email = "lucia@ejemplo.com" },
            new Contacto { Id = 12, Nombre = "Alberto Ruiz", Telefono = "602333444", Email = "alberto@ejemplo.com" },
            new Contacto { Id = 13, Nombre = "Carmen Vega", Telefono = "602555666", Email = "carmen@ejemplo.com" },
            new Contacto { Id = 14, Nombre = "Raúl Moreno", Telefono = "602777888", Email = "raul@ejemplo.com" },
            new Contacto { Id = 15, Nombre = "Marta Romero", Telefono = "602999000", Email = "marta@ejemplo.com" },
            new Contacto { Id = 16, Nombre = "Sergio Navarro", Telefono = "603111222", Email = "sergio@ejemplo.com" },
            new Contacto { Id = 17, Nombre = "Nuria Gil", Telefono = "603333444", Email = "nuria@ejemplo.com" },
            new Contacto { Id = 18, Nombre = "Andrés Serrano", Telefono = "603555666", Email = "andres@ejemplo.com" },
            new Contacto { Id = 19, Nombre = "Paula Molina", Telefono = "603777888", Email = "paula@ejemplo.com" },
            new Contacto { Id = 20, Nombre = "Iván Castro", Telefono = "603999000", Email = "ivan@ejemplo.com" }
        );
    }
}