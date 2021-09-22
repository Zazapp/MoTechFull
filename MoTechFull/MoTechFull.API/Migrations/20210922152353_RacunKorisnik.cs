using Microsoft.EntityFrameworkCore.Migrations;

namespace MoTechFull.API.Migrations
{
    public partial class RacunKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Racun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Racun_KorisnickiNalogId",
                table: "Racun",
                column: "KorisnickiNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_KorisnickiNalog_KorisnickiNalogId",
                table: "Racun",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "KorisnickiNalogId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Racun_KorisnickiNalog_KorisnickiNalogId",
                table: "Racun");

            migrationBuilder.DropIndex(
                name: "IX_Racun_KorisnickiNalogId",
                table: "Racun");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Racun");
        }
    }
}
