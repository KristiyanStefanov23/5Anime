using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveAnime.Data.Migrations
{
    public partial class AnimeFiltersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiltersId",
                table: "Animes");

            migrationBuilder.CreateTable(
                name: "AnimeFilters",
                columns: table => new
                {
                    AnimeId = table.Column<int>(type: "int", nullable: false),
                    FilterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeFilters", x => new { x.FilterId, x.AnimeId });
                    table.ForeignKey(
                        name: "FK_AnimeFilters_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimeFilters_Filters_FilterId",
                        column: x => x.FilterId,
                        principalTable: "Filters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeFilters_AnimeId",
                table: "AnimeFilters",
                column: "AnimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeFilters");

            migrationBuilder.AddColumn<string>(
                name: "FiltersId",
                table: "Animes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
