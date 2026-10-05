using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace AgendaContactos.Pages.Contactos;

[Authorize]
public class DetallesModel : PageModel
{
    private readonly IContactoService _contactoService;

    public DetallesModel(IContactoService contactoService)
    {
        _contactoService = contactoService;
    }

    public Contacto? Contacto { get; set; }

    public IActionResult OnGet(int id)
    {
        var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var contacto = _contactoService.ObtenerPorId(id);

        if (contacto is null || contacto.UsuarioId != usuarioId)
            return NotFound();

        Contacto = contacto;
        return Page();
    }
}