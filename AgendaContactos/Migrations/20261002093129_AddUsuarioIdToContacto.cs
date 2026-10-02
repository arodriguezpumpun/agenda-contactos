using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaContactos.Migrations
{
    /// <inheritdoc />
    public partial class AddUsuarioIdToContacto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Contactos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 4,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 5,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 6,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 7,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 8,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 9,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 10,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 11,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 12,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 13,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 14,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 15,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 16,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 17,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 18,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 19,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 20,
                column: "UsuarioId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_UsuarioId",
                table: "Contactos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactos_AspNetUsers_UsuarioId",
                table: "Contactos",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactos_AspNetUsers_UsuarioId",
                table: "Contactos");

            migrationBuilder.DropIndex(
                name: "IX_Contactos_UsuarioId",
                table: "Contactos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Contactos");
        }
    }
}
