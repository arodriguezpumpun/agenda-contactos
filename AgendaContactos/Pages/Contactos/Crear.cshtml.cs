using System.Security.Claims;
using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaContactos.Pages.Contactos;

[Authorize]
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
        
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();

        Contacto.UsuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        _contactoService.Anadir(Contacto);
        TempData["Mensaje"] = $"Contacto {Contacto.Nombre} añadido.";
        return RedirectToPage("Index");
    }
}