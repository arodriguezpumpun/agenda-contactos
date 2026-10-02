using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContactos.Migrations
{
    /// <inheritdoc />
    public partial class AddNotasToContacto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notas",
                table: "Contactos",
                type: "TEXT",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 16,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 17,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 18,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 19,
                column: "Notas",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 20,
                column: "Notas",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notas",
                table: "Contactos");
        }
    }
}
