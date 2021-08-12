using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveAnime.Data.Migrations
{
    public partial class FiltersImplementedAgainAnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FiltersId",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiltersId",
                table: "Animes");
        }
    }
}
