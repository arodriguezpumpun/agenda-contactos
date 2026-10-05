using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContactos.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreContactFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Contactos",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Contactos",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Contactos",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Favorito",
                table: "Contactos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Apellidos", "Categoria", "Empresa", "Favorito", "Notas" },
                values: new object[] { null, null, null, false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "Favorito",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "Notas",
                table: "Contactos");
        }
    }
}
