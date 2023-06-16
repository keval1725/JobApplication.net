using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class Addview : Migration
    {   
        /// <inheritdoc />  
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create  VIEW employee
 AS select b.First_name,e.board,e.PassYear  from BasicDetailes as b inner join educations as e on b.Basic_id = e.Basic_id  where b.Gender = 'Male'");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
