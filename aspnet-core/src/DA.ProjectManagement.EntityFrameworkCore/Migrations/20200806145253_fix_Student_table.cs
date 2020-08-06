using Microsoft.EntityFrameworkCore.Migrations;

namespace DA.ProjectManagement.Migrations
{
    public partial class fix_Student_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StundentCode",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StudentCode",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "StundentCode",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
