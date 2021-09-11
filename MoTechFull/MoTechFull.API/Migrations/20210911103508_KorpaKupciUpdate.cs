using Microsoft.EntityFrameworkCore.Migrations;

namespace MoTechFull.API.Migrations
{
    public partial class KorpaKupciUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_Kupac_KupacId",
                table: "Korpa");

            migrationBuilder.AlterColumn<int>(
                name: "KupacId",
                table: "KupacNarudzbe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "KupacNarudzbe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "KupacId",
                table: "Korpa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Korpa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_KupacNarudzbe_KupacId1",
                table: "KupacNarudzbe",
                column: "KorisnickiNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KupacId1",
                table: "Korpa",
                column: "KorisnickiNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_KorisnickiNalog_KorisnickiNalogId",
                table: "Korpa",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "KorisnickiNalogId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_Kupac_KupacId",
                table: "Korpa",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "KupacId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KupacNarudzbe_KorisnickiNalog_KorisnickiNalogId",
                table: "KupacNarudzbe",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "KorisnickiNalogId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_KorisnickiNalog_KorisnickiNalogId",
                table: "Korpa");

            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_Kupac_KupacId",
                table: "Korpa");

            migrationBuilder.DropForeignKey(
                name: "FK_KupacNarudzbe_KorisnickiNalog_KorisnickiNalogId",
                table: "KupacNarudzbe");

            migrationBuilder.DropIndex(
                name: "IX_KupacNarudzbe_KupacId1",
                table: "KupacNarudzbe");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_KupacId1",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "KupacNarudzbe");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Korpa");

            migrationBuilder.AlterColumn<int>(
                name: "KupacId",
                table: "KupacNarudzbe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KupacId",
                table: "Korpa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_Kupac_KupacId",
                table: "Korpa",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "KupacId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
