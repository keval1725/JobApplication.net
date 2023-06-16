using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicDetailes",
                columns: table => new
                {
                    Basic_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESIGNATION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADDRESS1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADDRESS2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RELATIONSHIP_STATUS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicDetailes", x => x.Basic_id);
                });

            migrationBuilder.CreateTable(
                name: "SelectMaster",
                columns: table => new
                {
                    SelectMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterFieldName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectMaster", x => x.SelectMasterId);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Board = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassYear = table.Column<int>(type: "int", nullable: false),
                    Percentage = table.Column<int>(type: "int", nullable: false),
                    Basic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                    table.ForeignKey(
                        name: "FK_Educations_BasicDetailes_Basic_id",
                        column: x => x.Basic_id,
                        principalTable: "BasicDetailes",
                        principalColumn: "Basic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Langauges",
                columns: table => new
                {
                    Langauge_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    langauge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Read = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Write = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speak = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Basic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langauges", x => x.Langauge_Id);
                    table.ForeignKey(
                        name: "FK_Langauges_BasicDetailes_Basic_id",
                        column: x => x.Basic_id,
                        principalTable: "BasicDetailes",
                        principalColumn: "Basic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prefrences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreferedLocation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoticePeriod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExpectedCTC = table.Column<long>(type: "bigint", nullable: false),
                    CurrentCTC = table.Column<long>(type: "bigint", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Basic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefrences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prefrences_BasicDetailes_Basic_id",
                        column: x => x.Basic_id,
                        principalTable: "BasicDetailes",
                        principalColumn: "Basic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refrences",
                columns: table => new
                {
                    RefrenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferencePersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReferencePersonContact = table.Column<long>(type: "bigint", nullable: false),
                    RefrencePersonRelation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Basic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refrences", x => x.RefrenceId);
                    table.ForeignKey(
                        name: "FK_Refrences_BasicDetailes_Basic_id",
                        column: x => x.Basic_id,
                        principalTable: "BasicDetailes",
                        principalColumn: "Basic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnologyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Basic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technologies_BasicDetailes_Basic_id",
                        column: x => x.Basic_id,
                        principalTable: "BasicDetailes",
                        principalColumn: "Basic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperince",
                columns: table => new
                {
                    Work_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESIGNATION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Basic_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperince", x => x.Work_Id);
                    table.ForeignKey(
                        name: "FK_WorkExperince_BasicDetailes_Basic_id",
                        column: x => x.Basic_id,
                        principalTable: "BasicDetailes",
                        principalColumn: "Basic_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OptionMaster",
                columns: table => new
                {
                    OptionMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionMasterFieldName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectMasterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionMaster", x => x.OptionMasterId);
                    table.ForeignKey(
                        name: "FK_OptionMaster_SelectMaster_SelectMasterId",
                        column: x => x.SelectMasterId,
                        principalTable: "SelectMaster",
                        principalColumn: "SelectMasterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SelectMaster",
                columns: new[] { "SelectMasterId", "MasterFieldName" },
                values: new object[,]
                {
                    { 1, "Language" },
                    { 2, "Technology" },
                    { 8, "Gender" },
                    { 9, "Relation" },
                    { 10, "CourseName" },
                    { 11, "PreferedLocation" },
                    { 12, "Department" }
                });

            migrationBuilder.InsertData(
                table: "OptionMaster",
                columns: new[] { "OptionMasterId", "OptionMasterFieldName", "SelectMasterId" },
                values: new object[,]
                {
                    { 32, "Gujrati", 1 },
                    { 33, "English", 1 },
                    { 34, "Hindi", 1 },
                    { 35, "Spanish", 1 },
                    { 36, "Mehoni", 1 },
                    { 37, "ASP.Net", 2 },
                    { 38, "Laravell", 2 },
                    { 39, "Django", 2 },
                    { 40, "Express.js", 2 },
                    { 41, "Nest.Js", 2 },
                    { 42, "Flutur", 2 },
                    { 43, "Male", 8 },
                    { 44, "Female", 8 },
                    { 45, "Other", 8 },
                    { 46, "Single", 9 },
                    { 47, "Mingle", 9 },
                    { 48, "Married", 9 },
                    { 49, "Divorced", 9 },
                    { 50, "SSC", 10 },
                    { 51, "HSC", 10 },
                    { 52, "Bacholar", 10 },
                    { 53, "Master", 10 },
                    { 54, "Surat", 11 },
                    { 55, "Ahemdabad", 11 },
                    { 56, "Rajkot", 11 },
                    { 57, "Vadodara", 11 },
                    { 58, "Developement", 12 },
                    { 59, "Networking", 12 },
                    { 60, "HR", 12 },
                    { 61, "Designing", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_Basic_id",
                table: "Educations",
                column: "Basic_id");

            migrationBuilder.CreateIndex(
                name: "IX_Langauges_Basic_id",
                table: "Langauges",
                column: "Basic_id");

            migrationBuilder.CreateIndex(
                name: "IX_OptionMaster_SelectMasterId",
                table: "OptionMaster",
                column: "SelectMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Prefrences_Basic_id",
                table: "Prefrences",
                column: "Basic_id");

            migrationBuilder.CreateIndex(
                name: "IX_Refrences_Basic_id",
                table: "Refrences",
                column: "Basic_id");

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_Basic_id",
                table: "Technologies",
                column: "Basic_id");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperince_Basic_id",
                table: "WorkExperince",
                column: "Basic_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Langauges");

            migrationBuilder.DropTable(
                name: "OptionMaster");

            migrationBuilder.DropTable(
                name: "Prefrences");

            migrationBuilder.DropTable(
                name: "Refrences");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "WorkExperince");

            migrationBuilder.DropTable(
                name: "SelectMaster");

            migrationBuilder.DropTable(
                name: "BasicDetailes");
        }
    }
}
