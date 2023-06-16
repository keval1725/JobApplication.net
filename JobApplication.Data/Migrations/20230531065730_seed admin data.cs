using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedadmindata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Registration",
                columns: new[] { "Id", "Email", "IsRole", "Password", "User_Name" },
                values: new object[] { 1, "Admin@123.com", 0, "admin@123", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
