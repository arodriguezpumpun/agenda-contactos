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

    // ─── Paginación ───
    private const int PageSize = 10;   // Contactos por página

    public int CurrentPage { get; set; } = 1;
    public int TotalPages { get; set; }
    public bool HasPreviousPage => CurrentPage > 1;
    public bool HasNextPage => CurrentPage < TotalPages;

    public IEnumerable<Contacto> Contactos { get; private set; } = [];

    [BindProperty(SupportsGet = true)]
    public string? Busqueda { get; set; }

    // ⬇️ CAMBIO: Page → PageNumber (evita conflicto con PageModel.Page)
    [BindProperty(SupportsGet = true)]
    public int PageNumber { get; set; } = 1;

    public void OnGet()
    {
        var contactos = _contactoService.ObtenerTodos();

        // 1. Filtrar por búsqueda (si hay)
        if (!string.IsNullOrWhiteSpace(Busqueda))
        {
            contactos = contactos.Where(c =>
                c.Nombre.Contains(Busqueda.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // 2. Calcular total de páginas
        var totalItems = contactos.Count();
        TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

        // 3. Asegurar que la página actual es válida
        // ⬇️ CAMBIO: usa PageNumber en lugar de Page
        CurrentPage = PageNumber < 1 ? 1 : (PageNumber > TotalPages ? TotalPages : PageNumber);

        // 4. Aplicar paginación
        Contactos = contactos
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .ToList();
    }

    public IActionResult OnPostBorrar(int id)
    {
        _contactoService.Borrar(id);
        TempData["Mensaje"] = "Contacto borrado.";
        return RedirectToPage();
    }
}