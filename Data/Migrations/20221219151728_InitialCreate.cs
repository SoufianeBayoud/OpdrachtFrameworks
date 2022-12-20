using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpdrachtFrameworks.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Immo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    straat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    huisnummer = table.Column<int>(type: "int", nullable: false),
                    gemeente = table.Column<int>(type: "int", nullable: false),
                    prijs = table.Column<double>(type: "float", nullable: false),
                    bouwjaar = table.Column<int>(type: "int", nullable: false),
                    kamers = table.Column<int>(type: "int", nullable: false),
                    grootte = table.Column<int>(type: "int", nullable: false),
                    tuin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immo", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Immo");
        }
    }
}
