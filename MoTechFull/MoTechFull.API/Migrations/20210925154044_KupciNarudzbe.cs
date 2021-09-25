using Microsoft.EntityFrameworkCore.Migrations;

namespace MoTechFull.API.Migrations
{
    public partial class KupciNarudzbe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdresaId",
                table: "KupacNarudzbe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresaId",
                table: "KupacNarudzbe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
