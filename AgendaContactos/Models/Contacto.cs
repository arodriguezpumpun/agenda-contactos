using System.ComponentModel.DataAnnotations;
namespace AgendaContactos.Models;
public class Contacto
{
public int Id { get; set; }
[Required(ErrorMessage = "El nombre es obligatorio.")]
[StringLength(100, ErrorMessage = "Máximo 100 caracteres.")]
public string Nombre { get; set; } = string.Empty;
[Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
[Display(Name = "Teléfono")]
public string? Telefono { get; set; }
[Required(ErrorMessage = "El email es obligatorio.")]
[EmailAddress(ErrorMessage = "El email no tiene un formato válido.")]
public string Email { get; set; } = string.Empty;
}