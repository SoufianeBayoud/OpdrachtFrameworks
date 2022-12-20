using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpdrachtFrameworks.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Immo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Facture",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Facture_Immo_id",
                table: "Facture",
                column: "id",
                principalTable: "Immo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facture_Klant_id",
                table: "Facture",
                column: "id",
                principalTable: "Klant",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Immo_Klant_id",
                table: "Immo",
                column: "id",
                principalTable: "Klant",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facture_Immo_id",
                table: "Facture");

            migrationBuilder.DropForeignKey(
                name: "FK_Facture_Klant_id",
                table: "Facture");

            migrationBuilder.DropForeignKey(
                name: "FK_Immo_Klant_id",
                table: "Immo");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Immo",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Facture",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
