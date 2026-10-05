using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace AgendaContactos.Pages;

[Authorize]
public class IndexModel : PageModel
{
    private readonly IContactoService _contactoService;

    public IndexModel(IContactoService contactoService)
    {
        _contactoService = contactoService;
    }

    public int TotalContactos { get; set; }
    public int TotalFavoritos { get; set; }
    public List<Contacto> UltimosContactos { get; set; } = new();
    public Dictionary<string, int> PorCategoria { get; set; } = new();

    public void OnGet()
    {
        var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var contactos = _contactoService.ObtenerTodos(usuarioId).ToList();

        TotalContactos = contactos.Count;
        TotalFavoritos = contactos.Count(c => c.Favorito);

        UltimosContactos = contactos
            .OrderByDescending(c => c.Id)
            .Take(5)
            .ToList();

        PorCategoria = contactos
            .Where(c => !string.IsNullOrEmpty(c.Categoria))
            .GroupBy(c => c.Categoria!)
            .ToDictionary(g => g.Key, g => g.Count());
    }
}