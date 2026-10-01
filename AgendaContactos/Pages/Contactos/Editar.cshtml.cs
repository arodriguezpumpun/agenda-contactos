using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaContactos.Pages.Contactos;

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

        // Copia para no modificar el objeto de la lista antes de validar
        Contacto = new Contacto
        {
            Id = contacto.Id,
            Nombre = contacto.Nombre,
            Telefono = contacto.Telefono,
            Email = contacto.Email
        };

        return Page();
    }

    public IActionResult OnPost(int id)
    {
        if (!ModelState.IsValid) return Page();

        Contacto.Id = id;
        _contactoService.Actualizar(Contacto);
        TempData["Mensaje"] = "Contacto actualizado.";
        return RedirectToPage("Index");
    }
}