using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryApp.Migrations
{
    public partial class Reservation_003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Livres_Id",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_LivreId",
                table: "Reservations",
                column: "LivreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Livres_LivreId",
                table: "Reservations",
                column: "LivreId",
                principalTable: "Livres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Livres_LivreId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_LivreId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Livres_Id",
                table: "Reservations",
                column: "Id",
                principalTable: "Livres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
