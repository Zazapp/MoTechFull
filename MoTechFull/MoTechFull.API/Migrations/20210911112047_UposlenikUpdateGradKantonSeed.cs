using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoTechFull.API.Migrations
{
    public partial class UposlenikUpdateGradKantonSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Novosti_Uposlenik_UposlenikId",
                table: "Novosti");

            migrationBuilder.DropForeignKey(
                name: "FK_Racun_Uposlenik_UposlenikId",
                table: "Racun");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropIndex(
                name: "IX_Racun_UposlenikId",
                table: "Racun");

            migrationBuilder.DropIndex(
                name: "IX_Novosti_UposlenikId",
                table: "Novosti");

            migrationBuilder.DropColumn(
                name: "UposlenikId",
                table: "Racun");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UposlenikId",
                table: "Racun",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZaposlenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isAktivan = table.Column<bool>(type: "bit", nullable: false),
                    IznosPlate = table.Column<double>(type: "float", nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.UposlenikId);
                    table.ForeignKey(
                        name: "FK_Uposlenik_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uposlenik_KorisnickiNalog_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalog",
                        principalColumn: "KorisnickiNalogId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Racun_UposlenikId",
                table: "Racun",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_UposlenikId",
                table: "Novosti",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_GradId",
                table: "Uposlenik",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_KorisnickiNalogId",
                table: "Uposlenik",
                column: "KorisnickiNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Novosti_Uposlenik_UposlenikId",
                table: "Novosti",
                column: "UposlenikId",
                principalTable: "Uposlenik",
                principalColumn: "UposlenikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Racun_Uposlenik_UposlenikId",
                table: "Racun",
                column: "UposlenikId",
                principalTable: "Uposlenik",
                principalColumn: "UposlenikId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
