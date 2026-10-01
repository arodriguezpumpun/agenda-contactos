using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaContactos.Pages.Contactos;

public class CrearModel : PageModel
{
    private readonly IContactoService _contactoService;

    public CrearModel(IContactoService contactoService)
    {
        _contactoService = contactoService;
    }

    [BindProperty]
    public Contacto Contacto { get; set; } = new();

    public void OnGet()
    {
        // No hace nada especial al cargar la página
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page(); // vuelve a mostrar el formulario con los errores
        }

        _contactoService.Anadir(Contacto);
        TempData["Mensaje"] = $"Contacto {Contacto.Nombre} añadido.";
        return RedirectToPage("Index");
    }
}