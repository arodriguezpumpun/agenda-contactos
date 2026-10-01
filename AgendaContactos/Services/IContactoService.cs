using AgendaContactos.Models;
namespace AgendaContactos.Services;
public interface IContactoService
{
IEnumerable<Contacto> ObtenerTodos();
Contacto? ObtenerPorId(int id);
void Anadir(Contacto contacto);
void Actualizar(Contacto contacto);
void Borrar(int id);
}