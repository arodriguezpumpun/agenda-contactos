using AgendaContactos.Models;
namespace AgendaContactos.Services;

public interface IContactoService
{
    IEnumerable<Contacto> ObtenerTodos(string usuarioId);
    Contacto? ObtenerPorId(int id);
    void Anadir(Contacto contacto);
    void Actualizar(Contacto contacto);
    void Borrar(int id);
    void ToggleFavorito(int id);

}