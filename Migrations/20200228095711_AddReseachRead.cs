using Microsoft.EntityFrameworkCore.Migrations;

namespace WebResearch.Migrations
{
    public partial class AddReseachRead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Read",
                table: "ResearchLinks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Read",
                table: "ResearchLinks");
        }
    }
}
