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

    private const int PageSize = 10;

    public int CurrentPage { get; set; } = 1;
    public int TotalPages { get; set; }
    public bool HasPreviousPage => CurrentPage > 1;
    public bool HasNextPage => CurrentPage < TotalPages;

    public IEnumerable<Contacto> Contactos { get; private set; } = [];

    [BindProperty(SupportsGet = true)]
    public string? Busqueda { get; set; }

    [BindProperty(SupportsGet = true)]
    public int PageNumber { get; set; } = 1;

    [BindProperty(SupportsGet = true)]
    public string Orden { get; set; } = "nombre";

    [BindProperty(SupportsGet = true)]
    public string Direccion { get; set; } = "asc";

    [BindProperty(SupportsGet = true)]
    public bool SoloFavoritos { get; set; } = false;

    public void OnGet()
    {
        var contactos = _contactoService.ObtenerTodos();

        // 1. Filtrar por favoritos (si está activado)
        if (SoloFavoritos)
        {
            contactos = contactos.Where(c => c.Favorito);
        }

        // 2. Filtrar por búsqueda (nombre o apellidos)
        if (!string.IsNullOrWhiteSpace(Busqueda))
        {
            contactos = contactos.Where(c =>
                c.Nombre.Contains(Busqueda.Trim(), StringComparison.OrdinalIgnoreCase) ||
                (c.Apellidos != null && c.Apellidos.Contains(Busqueda.Trim(), StringComparison.OrdinalIgnoreCase)));
        }

        // 3. Ordenar
        contactos = Ordenar(contactos, Orden, Direccion);

        // 4. Calcular total de páginas
        var totalItems = contactos.Count();
        TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

        // 5. Ajustar página actual
        CurrentPage = PageNumber < 1 ? 1 : (PageNumber > TotalPages ? TotalPages : PageNumber);

        // 6. Aplicar paginación
        Contactos = contactos
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .ToList();
    }

    private IEnumerable<Contacto> Ordenar(IEnumerable<Contacto> contactos, string orden, string direccion)
    {
        var esDesc = direccion?.ToLower() == "desc";

        return orden?.ToLower() switch
        {
            "nombre" => esDesc
                ? contactos.OrderByDescending(c => c.Nombre)
                : contactos.OrderBy(c => c.Nombre),
            "apellidos" => esDesc
                ? contactos.OrderByDescending(c => c.Apellidos)
                : contactos.OrderBy(c => c.Apellidos),
            "apodo" => esDesc
                ? contactos.OrderByDescending(c => c.Apodo)
                : contactos.OrderBy(c => c.Apodo),
            "telefono" => esDesc
                ? contactos.OrderByDescending(c => c.Telefono)
                : contactos.OrderBy(c => c.Telefono),
            "email" => esDesc
                ? contactos.OrderByDescending(c => c.Email)
                : contactos.OrderBy(c => c.Email),
            _ => contactos.OrderBy(c => c.Nombre)
        };
    }

    public IActionResult OnPostBorrar(int id)
    {
        _contactoService.Borrar(id);
        TempData["Mensaje"] = "Contacto borrado.";
        return RedirectToPage();
    }

    public IActionResult OnPostToggleFavorito(int id)
    {
        _contactoService.ToggleFavorito(id);
        return RedirectToPage();
    }
}