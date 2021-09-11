using Microsoft.EntityFrameworkCore.Migrations;

namespace MoTechFull.API.Migrations
{
    public partial class RacunUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Racun_Uposlenik_UposlenikId",
                table: "Racun");

            migrationBuilder.AlterColumn<int>(
                name: "UposlenikId",
                table: "Racun",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_Uposlenik_UposlenikId",
                table: "Racun",
                column: "UposlenikId",
                principalTable: "Uposlenik",
                principalColumn: "UposlenikId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Racun_Uposlenik_UposlenikId",
                table: "Racun");

            migrationBuilder.AlterColumn<int>(
                name: "UposlenikId",
                table: "Racun",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_Uposlenik_UposlenikId",
                table: "Racun",
                column: "UposlenikId",
                principalTable: "Uposlenik",
                principalColumn: "UposlenikId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
