using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovidWebAPI.Migrations
{
    public partial class db5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CovidDetails",
                columns: table => new
                {
                    CountryName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    InfectedCases = table.Column<int>(type: "int", nullable: true),
                    RecoveredCases = table.Column<int>(type: "int", nullable: true),
                    DeceasedCases = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidDetails", x => x.CountryName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CovidDetails");
        }
    }
}
