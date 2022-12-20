using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpdrachtFrameworks.Data.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "diseappear",
                table: "Klant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "diseappear",
                table: "Immo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "diseappear",
                table: "Facture",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diseappear",
                table: "Klant");

            migrationBuilder.DropColumn(
                name: "diseappear",
                table: "Immo");

            migrationBuilder.DropColumn(
                name: "diseappear",
                table: "Facture");
        }
    }
}
