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
            new Contacto { Id = 1, Nombre = "Ana", Apellidos = "García", Apodo = "La Jefa", Email = "ana@ejemplo.com", Telefono = "600111222", Favorito = true },
            new Contacto { Id = 2, Nombre = "Luis", Apellidos = "Pérez", Apodo = "Luisito", Email = "luis@ejemplo.com", Telefono = "600333444", Favorito = false },
            new Contacto { Id = 3, Nombre = "María", Apellidos = "López", Apodo = "Mery", Email = "maria@ejemplo.com", Telefono = "600555666", Favorito = true },
            new Contacto { Id = 4, Nombre = "Carlos", Apellidos = "Ruiz", Apodo = "Carlitos", Email = "carlos@ejemplo.com", Telefono = "600777888", Favorito = false },
            new Contacto { Id = 5, Nombre = "Laura", Apellidos = "Fernández", Apodo = "Laurita", Email = "laura@ejemplo.com", Telefono = "600999000", Favorito = false },
            new Contacto { Id = 6, Nombre = "Javier", Apellidos = "Sánchez", Apodo = "Javi", Email = "javier@ejemplo.com", Telefono = "601111222", Favorito = true },
            new Contacto { Id = 7, Nombre = "Elena", Apellidos = "Martín", Apodo = "Elenita", Email = "elena@ejemplo.com", Telefono = "601333444", Favorito = false },
            new Contacto { Id = 8, Nombre = "David", Apellidos = "Gómez", Apodo = "Davo", Email = "david@ejemplo.com", Telefono = "601555666", Favorito = false },
            new Contacto { Id = 9, Nombre = "Sara", Apellidos = "Jiménez", Apodo = "Sarita", Email = "sara@ejemplo.com", Telefono = "601777888", Favorito = true },
            new Contacto { Id = 10, Nombre = "Pablo", Apellidos = "Díaz", Apodo = "Pablito", Email = "pablo@ejemplo.com", Telefono = "601999000", Favorito = false },
            new Contacto { Id = 11, Nombre = "Lucía", Apellidos = "Torres", Apodo = "Lucy", Email = "lucia@ejemplo.com", Telefono = "602111222", Favorito = false },
            new Contacto { Id = 12, Nombre = "Alberto", Apellidos = "Ruiz", Apodo = "Alber", Email = "alberto@ejemplo.com", Telefono = "602333444", Favorito = false },
            new Contacto { Id = 13, Nombre = "Carmen", Apellidos = "Vega", Apodo = "Carmencita", Email = "carmen@ejemplo.com", Telefono = "602555666", Favorito = true },
            new Contacto { Id = 14, Nombre = "Raúl", Apellidos = "Moreno", Apodo = "Raulito", Email = "raul@ejemplo.com", Telefono = "602777888", Favorito = false },
            new Contacto { Id = 15, Nombre = "Marta", Apellidos = "Romero", Apodo = "Martita", Email = "marta@ejemplo.com", Telefono = "602999000", Favorito = false },
            new Contacto { Id = 16, Nombre = "Sergio", Apellidos = "Navarro", Apodo = "Sergi", Email = "sergio@ejemplo.com", Telefono = "603111222", Favorito = false },
            new Contacto { Id = 17, Nombre = "Nuria", Apellidos = "Gil", Apodo = "Nuri", Email = "nuria@ejemplo.com", Telefono = "603333444", Favorito = true },
            new Contacto { Id = 18, Nombre = "Andrés", Apellidos = "Serrano", Apodo = "Andresito", Email = "andres@ejemplo.com", Telefono = "603555666", Favorito = false },
            new Contacto { Id = 19, Nombre = "Paula", Apellidos = "Molina", Apodo = "Paulita", Email = "paula@ejemplo.com", Telefono = "603777888", Favorito = false },
            new Contacto { Id = 20, Nombre = "Iván", Apellidos = "Castro", Apodo = "Ivanito", Email = "ivan@ejemplo.com", Telefono = "603999000", Favorito = false }
        );
    }
}