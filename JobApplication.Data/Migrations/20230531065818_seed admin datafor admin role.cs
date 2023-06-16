using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedadmindataforadminrole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsRole",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Registration",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsRole",
                value: 0);
        }
    }
}
