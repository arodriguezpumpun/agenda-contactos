using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgendaContactos.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedContacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contactos",
                columns: new[] { "Id", "Email", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "ana@ejemplo.com", "Ana García", "600111222" },
                    { 2, "luis@ejemplo.com", "Luis Pérez", "600333444" },
                    { 3, "maria@ejemplo.com", "María López", "600555666" },
                    { 4, "carlos@ejemplo.com", "Carlos Ruiz", "600777888" },
                    { 5, "laura@ejemplo.com", "Laura Fernández", "600999000" },
                    { 6, "javier@ejemplo.com", "Javier Sánchez", "601111222" },
                    { 7, "elena@ejemplo.com", "Elena Martín", "601333444" },
                    { 8, "david@ejemplo.com", "David Gómez", "601555666" },
                    { 9, "sara@ejemplo.com", "Sara Jiménez", "601777888" },
                    { 10, "pablo@ejemplo.com", "Pablo Díaz", "601999000" },
                    { 11, "lucia@ejemplo.com", "Lucía Torres", "602111222" },
                    { 12, "alberto@ejemplo.com", "Alberto Ruiz", "602333444" },
                    { 13, "carmen@ejemplo.com", "Carmen Vega", "602555666" },
                    { 14, "raul@ejemplo.com", "Raúl Moreno", "602777888" },
                    { 15, "marta@ejemplo.com", "Marta Romero", "602999000" },
                    { 16, "sergio@ejemplo.com", "Sergio Navarro", "603111222" },
                    { 17, "nuria@ejemplo.com", "Nuria Gil", "603333444" },
                    { 18, "andres@ejemplo.com", "Andrés Serrano", "603555666" },
                    { 19, "paula@ejemplo.com", "Paula Molina", "603777888" },
                    { 20, "ivan@ejemplo.com", "Iván Castro", "603999000" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contactos",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
