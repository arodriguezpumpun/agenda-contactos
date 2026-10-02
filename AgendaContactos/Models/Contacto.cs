using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaContactos.Models;

public class Contacto
{
    public int Id { get; set; }

    [Display(Name = "Foto")]
    [StringLength(500)]
    public string? FotoUrl { get; set; }

    public string? UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public ApplicationUser? Usuario { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
    [Display(Name = "Apellidos")]
    public string? Apellidos { get; set; }

    [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
    [Display(Name = "Apodo")]
    public string? Apodo { get; set; }

    [Required(ErrorMessage = "El email es obligatorio.")]
    [EmailAddress(ErrorMessage = "El email no tiene un formato válido.")]
    [Display(Name = "Email")]
    public string Email { get; set; } = string.Empty;

    [Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }

    [StringLength(2000, ErrorMessage = "Máximo 2000 caracteres.")]
    [Display(Name = "Notas")]
    public string? Notas { get; set; }

    [Display(Name = "Favorito")]
    public bool Favorito { get; set; } = false;
}