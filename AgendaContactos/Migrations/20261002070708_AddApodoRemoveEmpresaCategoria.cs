using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContactos.Migrations
{
    /// <inheritdoc />
    public partial class AddApodoRemoveEmpresaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "Notas",
                table: "Contactos");

            migrationBuilder.RenameColumn(
                name: "Categoria",
                table: "Contactos",
                newName: "Apodo");

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellidos", "Apodo", "Favorito", "Nombre" },
                values: new object[] { "García", "La Jefa", true, "Ana" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Pérez", "Luisito", "Luis" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Apellidos", "Apodo", "Favorito", "Nombre" },
                values: new object[] { "López", "Mery", true, "María" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Ruiz", "Carlitos", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Fernández", "Laurita", "Laura" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Apellidos", "Apodo", "Favorito", "Nombre" },
                values: new object[] { "Sánchez", "Javi", true, "Javier" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Martín", "Elenita", "Elena" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Gómez", "Davo", "David" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Apellidos", "Apodo", "Favorito", "Nombre" },
                values: new object[] { "Jiménez", "Sarita", true, "Sara" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Díaz", "Pablito", "Pablo" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Torres", "Lucy", "Lucía" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Ruiz", "Alber", "Alberto" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Apellidos", "Apodo", "Favorito", "Nombre" },
                values: new object[] { "Vega", "Carmencita", true, "Carmen" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Moreno", "Raulito", "Raúl" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Romero", "Martita", "Marta" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Navarro", "Sergi", "Sergio" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Apellidos", "Apodo", "Favorito", "Nombre" },
                values: new object[] { "Gil", "Nuri", true, "Nuria" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Serrano", "Andresito", "Andrés" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Molina", "Paulita", "Paula" });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Apellidos", "Apodo", "Nombre" },
                values: new object[] { "Castro", "Ivanito", "Iván" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Apodo",
                table: "Contactos",
                newName: "Categoria");

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Contactos",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notas",
                table: "Contactos",
                type: "TEXT",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Nombre", "Notas" },
                values: new object[] { null, null, null, false, "Ana García", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Luis Pérez", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Nombre", "Notas" },
                values: new object[] { null, null, null, false, "María López", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Carlos Ruiz", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Laura Fernández", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Nombre", "Notas" },
                values: new object[] { null, null, null, false, "Javier Sánchez", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Elena Martín", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "David Gómez", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Nombre", "Notas" },
                values: new object[] { null, null, null, false, "Sara Jiménez", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Pablo Díaz", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Lucía Torres", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Alberto Ruiz", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Nombre", "Notas" },
                values: new object[] { null, null, null, false, "Carmen Vega", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Raúl Moreno", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Marta Romero", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Sergio Navarro", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Nombre", "Notas" },
                values: new object[] { null, null, null, false, "Nuria Gil", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Andrés Serrano", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Paula Molina", null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Nombre", "Notas" },
                values: new object[] { null, null, null, "Iván Castro", null });
        }
    }
}
