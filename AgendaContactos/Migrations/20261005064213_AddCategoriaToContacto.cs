using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContactos.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriaToContacto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Contactos",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 16,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 17,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 18,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 19,
                column: "Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 20,
                column: "Categoria",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Contactos");
        }
    }
}
