using Microsoft.EntityFrameworkCore.Migrations;

namespace Ste.Data.Migrations
{
    public partial class AddedUniversityOfStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "University",
                table: "Students");
        }
    }
}
