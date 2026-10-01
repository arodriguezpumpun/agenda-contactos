using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace AgendaContactos.Pages.Contactos;

public class IndexModel : PageModel
{
    private readonly IContactoService _contactoService;
    public IndexModel(IContactoService contactoService)
    {
        _contactoService = contactoService;
    }
    public IEnumerable<Contacto> Contactos { get; private set; } = [];
    public void OnGet()
    {
        Contactos = _contactoService.ObtenerTodos();
    }
    public IActionResult OnPostBorrar(int id)
    {
        _contactoService.Borrar(id);
        TempData["Mensaje"] = "Contacto borrado.";
        return RedirectToPage();
    }
}