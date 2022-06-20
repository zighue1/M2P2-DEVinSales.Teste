using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevInSales.Migrations
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public partial class AjusteSeedsUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Profile",
                keyColumn: "id",
                keyValue: 1,
                column: "name",
                value: "Administrador");

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "id", "name" },
                values: new object[] { 2, "Gerente" });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "id", "name" },
                values: new object[] { 3, "Usuario" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 2,
                column: "ProfileId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 3,
                column: "ProfileId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 4,
                column: "ProfileId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Profile",
                keyColumn: "id",
                keyValue: 1,
                column: "name",
                value: "Cliente");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 2,
                column: "ProfileId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 3,
                column: "ProfileId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "id",
                keyValue: 4,
                column: "ProfileId",
                value: 1);
        }
    }
}
