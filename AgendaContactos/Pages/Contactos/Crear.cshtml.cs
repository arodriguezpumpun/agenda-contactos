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

    [BindProperty]
    public IFormFile? FotoFile { get; set; }

    public void OnGet()
    {

    }

public async Task<IActionResult> OnPost()
{
    if (!ModelState.IsValid) return Page();

    if (FotoFile != null && FotoFile.Length > 0)
    {
        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(FotoFile.FileName);
        var filePath = Path.Combine("wwwroot/images/contactos", fileName);

        Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await FotoFile.CopyToAsync(stream);
        }

        Contacto.FotoUrl = "/images/contactos/" + fileName;
    }

    Contacto.UsuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    _contactoService.Anadir(Contacto);
    TempData["Mensaje"] = $"Contacto {Contacto.Nombre} añadido.";
    return RedirectToPage("Index");
}
}