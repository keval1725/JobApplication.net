using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class fhjkdhfs : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BasicDetailes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "BasicDetailes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
