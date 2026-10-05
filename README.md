# Agenda de contactos
Pequeña aplicación web en ASP.NET Core (Razor Pages) para guardar contactos:
listar, añadir y borrar, con validación de nombre y email.
## Requisitos
- .NET SDK 10 (o 8) -> comprobar con `dotnet --version`
## Cómo arrancarlo
```bash
git clone https://github.com/TU-USUARIO/nombre-repo.git
cd nombre-repo/AgendaContactos
dotnet run
```
Abre en el navegador la URL que aparece en la terminal
(por ejemplo http://localhost:5123) y entra en **Contactos**.
## Funcionalidades
- Lista de contactos (nombre, teléfono, email)
- Alta con validación ([Required] y [EmailAddress])
- Borrado con confirmación
## Notas
Los datos se guardan en memoria (servicio Singleton):
se pierden al parar la aplicación.
## Estructura
- `Models/Contacto.cs` - modelo con Data Annotations
- `Services/ContactoService.cs` - lista en memoria
- `Pages/Contactos/` - páginas de lista y alta