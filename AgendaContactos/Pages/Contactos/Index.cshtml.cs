using System.Security.Claims;
using AgendaContactos.Models;
using AgendaContactos.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgendaContactos.Pages.Contactos;

[Authorize]
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
    public string? CategoriaFiltro { get; set; }

    [BindProperty(SupportsGet = true)]
    public bool SoloFavoritos { get; set; } = false;

    public int TotalContactos { get; set; }
    public int ContactosFiltrados { get; set; }

    public void OnGet()
    {
        var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var todosLosContactos = _contactoService.ObtenerTodos(usuarioId);

        TotalContactos = todosLosContactos.Count();

        var contactos = todosLosContactos;

        if (SoloFavoritos)
        {
            contactos = contactos.Where(c => c.Favorito);
        }

        if (!string.IsNullOrWhiteSpace(Busqueda))
        {
            contactos = contactos.Where(c =>
                c.Nombre.Contains(Busqueda.Trim(), StringComparison.OrdinalIgnoreCase) ||
                (c.Apellidos != null && c.Apellidos.Contains(Busqueda.Trim(), StringComparison.OrdinalIgnoreCase)));
        }

        if (!string.IsNullOrWhiteSpace(CategoriaFiltro))
        {
            contactos = contactos.Where(c => c.Categoria == CategoriaFiltro);
        }

        ContactosFiltrados = contactos.Count();

        contactos = Ordenar(contactos, Orden, Direccion);

        var totalItems = contactos.Count();
        TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

        CurrentPage = PageNumber < 1 ? 1 : (PageNumber > TotalPages ? TotalPages : PageNumber);

        Contactos = contactos
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .ToList();
    }

    public IActionResult OnGetTabla()
    {
        if (!Request.Headers.ContainsKey("HX-Request"))
        {
            return RedirectToPage("Index");
        }

        var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var todosLosContactos = _contactoService.ObtenerTodos(usuarioId);

        TotalContactos = todosLosContactos.Count();

        var contactos = todosLosContactos;

        if (SoloFavoritos)
        {
            contactos = contactos.Where(c => c.Favorito);
        }

        if (!string.IsNullOrWhiteSpace(Busqueda))
        {
            contactos = contactos.Where(c =>
                c.Nombre.Contains(Busqueda.Trim(), StringComparison.OrdinalIgnoreCase) ||
                (c.Apellidos != null && c.Apellidos.Contains(Busqueda.Trim(), StringComparison.OrdinalIgnoreCase)));
        }

        if (!string.IsNullOrWhiteSpace(CategoriaFiltro))
        {
            contactos = contactos.Where(c => c.Categoria == CategoriaFiltro);
        }

        ContactosFiltrados = contactos.Count();

        contactos = Ordenar(contactos, Orden, Direccion);

        var totalItems = contactos.Count();
        TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);

        CurrentPage = PageNumber < 1 ? 1 : (PageNumber > TotalPages ? TotalPages : PageNumber);

        Contactos = contactos
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .ToList();

        return Partial("_TablaContactos", this);
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
            "categoria" => esDesc
                ? contactos.OrderByDescending(c => c.Categoria)
                : contactos.OrderBy(c => c.Categoria),
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

    public IActionResult OnGetExportarCsv()
    {
        var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var contactos = _contactoService.ObtenerTodos(usuarioId).ToList();

        var csv = new System.Text.StringBuilder();
        csv.AppendLine("Nombre,Apellidos,Apodo,Telefono,Email,Notas,Favorito");

        foreach (var contacto in contactos)
        {
            var nombre = EscapeCsv(contacto.Nombre);
            var apellidos = EscapeCsv(contacto.Apellidos ?? "");
            var apodo = EscapeCsv(contacto.Apodo ?? "");
            var telefono = EscapeCsv(contacto.Telefono ?? "");
            var email = EscapeCsv(contacto.Email);
            var favorito = contacto.Favorito ? "Sí" : "No";

            csv.AppendLine($"{nombre},{apellidos},{apodo},{telefono},{email},{favorito}");
        }

        var bytes = System.Text.Encoding.UTF8.GetBytes(csv.ToString());
        var fileName = $"contactos_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

        return File(bytes, "text/csv", fileName);
    }

    private string EscapeCsv(string value)
    {
        if (string.IsNullOrEmpty(value))
            return "";

        if (value.Contains(",") || value.Contains("\"") || value.Contains("\n") || value.Contains("\r"))
        {
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        return value;
    }

    [BindProperty]
    public IFormFile? CsvFile { get; set; }

    public async Task<IActionResult> OnPostImportarCsvAsync()
    {
        if (CsvFile == null || CsvFile.Length == 0)
        {
            TempData["Mensaje"] = "No se ha seleccionado ningún archivo.";
            TempData["MensajeTipo"] = "danger";
            return RedirectToPage();
        }

        if (!CsvFile.FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
        {
            TempData["Mensaje"] = "El archivo debe ser un CSV.";
            TempData["MensajeTipo"] = "danger";
            return RedirectToPage();
        }

        var usuarioId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var importados = 0;
        var errores = 0;
        var mensajesError = new List<string>();

        using (var reader = new StreamReader(CsvFile.OpenReadStream()))
        {
            var cabecera = await reader.ReadLineAsync();

            string? linea;
            var numeroLinea = 1;

            while ((linea = await reader.ReadLineAsync()) != null)
            {
                numeroLinea++;

                if (string.IsNullOrWhiteSpace(linea))
                    continue;

                try
                {
                    var campos = ParsearLineaCsv(linea);

                    if (campos.Count < 5)
                    {
                        errores++;
                        mensajesError.Add($"Línea {numeroLinea}: faltan campos");
                        continue;
                    }

                    var contacto = new Contacto
                    {
                        Nombre = campos[0].Trim(),
                        Apellidos = campos.Count > 1 ? campos[1].Trim() : null,
                        Apodo = campos.Count > 2 ? campos[2].Trim() : null,
                        Telefono = campos.Count > 3 ? campos[3].Trim() : null,
                        Email = campos[4].Trim(),
                        Favorito = campos.Count > 6 && (campos[6].Trim().ToLower() == "sí" || campos[6].Trim().ToLower() == "si" || campos[6].Trim().ToLower() == "true" || campos[6].Trim() == "1"),
                        UsuarioId = usuarioId
                    };

                    // Validar campos obligatorios
                    if (string.IsNullOrWhiteSpace(contacto.Nombre))
                    {
                        errores++;
                        mensajesError.Add($"Línea {numeroLinea}: el nombre es obligatorio");
                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(contacto.Email))
                    {
                        errores++;
                        mensajesError.Add($"Línea {numeroLinea}: el email es obligatorio");
                        continue;
                    }

                    _contactoService.Anadir(contacto);
                    importados++;
                }
                catch (Exception ex)
                {
                    errores++;
                    mensajesError.Add($"Línea {numeroLinea}: {ex.Message}");
                }
            }
        }

        if (importados > 0)
        {
            TempData["Mensaje"] = $"Se han importado {importados} contactos." + (errores > 0 ? $" {errores} errores." : "");
            TempData["MensajeTipo"] = errores > 0 ? "warning" : "success";
        }
        else
        {
            TempData["Mensaje"] = "No se ha importado ningún contacto." + (errores > 0 ? $" {errores} errores." : "");
            TempData["MensajeTipo"] = "danger";
        }

        return RedirectToPage();
    }

    private List<string> ParsearLineaCsv(string linea)
    {
        var campos = new List<string>();
        var campoActual = new System.Text.StringBuilder();
        var dentroDeComillas = false;

        for (int i = 0; i < linea.Length; i++)
        {
            var c = linea[i];

            if (c == '"')
            {
                if (dentroDeComillas && i + 1 < linea.Length && linea[i + 1] == '"')
                {
                    campoActual.Append('"');
                    i++;
                }
                else
                {
                    dentroDeComillas = !dentroDeComillas;
                }
            }
            else if (c == ',' && !dentroDeComillas)
            {
                campos.Add(campoActual.ToString());
                campoActual.Clear();
            }
            else
            {
                campoActual.Append(c);
            }
        }

        campos.Add(campoActual.ToString());
        return campos;
    }
}