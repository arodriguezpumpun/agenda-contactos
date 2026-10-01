using AgendaContactos.Models;
using Microsoft.EntityFrameworkCore;
namespace AgendaContactos.Data;

public class AgendaDbContext : DbContext
{
    public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
    : base(options)
    {
    }
    // Cada DbSet es una tabla
    public DbSet<Contacto> Contactos => Set<Contacto>();
}