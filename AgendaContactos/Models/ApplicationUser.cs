using Microsoft.AspNetCore.Identity;

namespace AgendaContactos.Models;

public class ApplicationUser : IdentityUser
{
    [PersonalData]
    public string? NombreCompleto { get; set; }

    [PersonalData]
    public string? Apodo { get; set; }
}