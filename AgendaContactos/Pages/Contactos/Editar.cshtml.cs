using System.Security.Claims;
using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaContactos.Pages.Contactos;

[Authorize]
public class EditarModel : PageModel
{
    private readonly IContactoService _contactoService;

    public EditarModel(IContactoService contactoService)
    {
        _contactoService = contactoService;
    }

    [BindProperty]
    public Contacto Contacto { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var contacto = _contactoService.ObtenerPorId(id);
        if (contacto is null) return NotFound();

        Contacto = new Contacto
        {
            Id = contacto.Id,
            FotoUrl = contacto.FotoUrl,
            Nombre = contacto.Nombre,
            Apellidos = contacto.Apellidos,
            Apodo = contacto.Apodo,
            Telefono = contacto.Telefono,
            Email = contacto.Email,
            Notas = contacto.Notas,
            Favorito = contacto.Favorito,
        };

        return Page();
    }

    [BindProperty]
    public IFormFile? FotoFile { get; set; }

public async Task<IActionResult> OnPost(int id)
{
    if (!ModelState.IsValid) return Page();

    var contactoExistente = _contactoService.ObtenerPorId(id);
    if (contactoExistente is null) return NotFound();

    if (FotoFile != null && FotoFile.Length > 0)
    {
        if (!string.IsNullOrEmpty(contactoExistente.FotoUrl))
        {
            var oldFilePath = Path.Combine("wwwroot", contactoExistente.FotoUrl.TrimStart('/'));
            if (System.IO.File.Exists(oldFilePath))
            {
                System.IO.File.Delete(oldFilePath);
            }
        }

        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(FotoFile.FileName);
        var filePath = Path.Combine("wwwroot/images/contactos", fileName);

        Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await FotoFile.CopyToAsync(stream);
        }

        Contacto.FotoUrl = "/images/contactos/" + fileName;
    }
    else
    {
        Contacto.FotoUrl = contactoExistente.FotoUrl;
    }

    Contacto.Id = id;
    Contacto.UsuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    _contactoService.Actualizar(Contacto);

    TempData["Mensaje"] = "Contacto actualizado.";
    TempData["MensajeTipo"] = "success";
    return RedirectToPage("Index");
}
}