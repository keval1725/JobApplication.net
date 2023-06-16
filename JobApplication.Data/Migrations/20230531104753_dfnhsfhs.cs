using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class dfnhsfhs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasicDetailes_Registration_RegistrationId",
                table: "BasicDetailes");

            migrationBuilder.DropIndex(
                name: "IX_BasicDetailes_RegistrationId",
                table: "BasicDetailes");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "BasicDetailes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "BasicDetailes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasicDetailes_RegistrationId",
                table: "BasicDetailes",
                column: "RegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicDetailes_Registration_RegistrationId",
                table: "BasicDetailes",
                column: "RegistrationId",
                principalTable: "Registration",
                principalColumn: "Id");
        }
    }
}
