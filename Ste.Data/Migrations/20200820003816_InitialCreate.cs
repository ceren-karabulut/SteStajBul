using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ste.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisiments",
                columns: table => new
                {
                    AdvertisimentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<string>(nullable: true),
                    JobTitle = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    JobDesc = table.Column<string>(nullable: true),
                    NumberOfStudents = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisiments", x => x.AdvertisimentId);
                    table.ForeignKey(
                        name: "FK_Advertisiments_AspNetUsers_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfGraduation = table.Column<DateTime>(nullable: false),
                    Section = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    DayOfIntern = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    AdvertisimentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Advertisiments_AdvertisimentId",
                        column: x => x.AdvertisimentId,
                        principalTable: "Advertisiments",
                        principalColumn: "AdvertisimentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisiments_CompanyId",
                table: "Advertisiments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AdvertisimentId",
                table: "Students",
                column: "AdvertisimentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Advertisiments");
        }
    }
}
