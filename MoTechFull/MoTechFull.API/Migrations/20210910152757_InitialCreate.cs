using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoTechFull.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kanton",
                columns: table => new
                {
                    KantonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oznaka = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kanton", x => x.KantonId);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickiNalog",
                columns: table => new
                {
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lozinka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tip = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalog", x => x.KorisnickiNalogId);
                });

            migrationBuilder.CreateTable(
                name: "Ponuda",
                columns: table => new
                {
                    PonudaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponuda", x => x.PonudaId);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjac",
                columns: table => new
                {
                    ProizvodjacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjac", x => x.ProizvodjacId);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KantonId = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostanskiBroj = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                    table.ForeignKey(
                        name: "FK_Grad_Kanton_KantonId",
                        column: x => x.KantonId,
                        principalTable: "Kanton",
                        principalColumn: "KantonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacijskiToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vrijednost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: false),
                    VrijemeEvidentiranja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IpAdresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacijskiToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutorizacijskiToken_KorisnickiNalog_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalog",
                        principalColumn: "KorisnickiNalogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artikal",
                columns: table => new
                {
                    ArtikalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategorijaId = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cijena = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ProizvodjacId = table.Column<int>(type: "int", nullable: false),
                    Dostupan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikal", x => x.ArtikalId);
                    table.ForeignKey(
                        name: "FK_Artikal_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artikal_Proizvodjac_ProizvodjacId",
                        column: x => x.ProizvodjacId,
                        principalTable: "Proizvodjac",
                        principalColumn: "ProizvodjacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dobavljac",
                columns: table => new
                {
                    DobavljacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljac", x => x.DobavljacId);
                    table.ForeignKey(
                        name: "FK_Dobavljac_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kupac",
                columns: table => new
                {
                    KupacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailAdresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: false),
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupac", x => x.KupacId);
                    table.ForeignKey(
                        name: "FK_Kupac_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kupac_KorisnickiNalog_KorisnickiNalogId",
                        column: x => x.KorisnickiNalogId,
                        principalTable: "KorisnickiNalog",
                        principalColumn: "KorisnickiNalogId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZaposlenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IznosPlate = table.Column<double>(type: "float", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: true),
                    KorisnickiNalogId = table.Column<int>(type: "int", nullable: true),
                    isAktivan = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ArtikalPonuda",
                columns: table => new
                {
                    ArtikalId = table.Column<int>(type: "int", nullable: false),
                    PonudaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtikalPonuda", x => new { x.ArtikalId, x.PonudaId });
                    table.ForeignKey(
                        name: "FK_ArtikalPonuda_Artikal_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikal",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtikalPonuda_Ponuda_PonudaId",
                        column: x => x.PonudaId,
                        principalTable: "Ponuda",
                        principalColumn: "PonudaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DobavljacNarudzba",
                columns: table => new
                {
                    DobavljacNarudzbaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DobavljacId = table.Column<int>(type: "int", nullable: false),
                    DatumIsporuke = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsIsporucena = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DobavljacNarudzba", x => x.DobavljacNarudzbaId);
                    table.ForeignKey(
                        name: "FK_DobavljacNarudzba_Dobavljac_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljac",
                        principalColumn: "DobavljacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    KorpaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacId = table.Column<int>(type: "int", nullable: false),
                    DatumDodavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.KorpaId);
                    table.ForeignKey(
                        name: "FK_Korpa_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KupacNarudzbe",
                columns: table => new
                {
                    KupacNarudzbeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacId = table.Column<int>(type: "int", nullable: false),
                    AdresaId = table.Column<int>(type: "int", nullable: false),
                    AdresaDostave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsIsporucena = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupacNarudzbe", x => x.KupacNarudzbeId);
                    table.ForeignKey(
                        name: "FK_KupacNarudzbe_Grad_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupacNarudzbe_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    RecenzijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtikalId = table.Column<int>(type: "int", nullable: false),
                    KupacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.RecenzijaId);
                    table.ForeignKey(
                        name: "FK_Recenzija_Artikal_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikal",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzija_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    NovostiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UposlenikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.NovostiId);
                    table.ForeignKey(
                        name: "FK_Novosti_Uposlenik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikId = table.Column<int>(type: "int", nullable: false),
                    DatumIzdavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Iznos = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunId);
                    table.ForeignKey(
                        name: "FK_Racun_Uposlenik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DobavljacNarudzbaStavke",
                columns: table => new
                {
                    DobavljacNarudzbaStavkeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtikalId = table.Column<int>(type: "int", nullable: false),
                    DobavljacNarudzbaId = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<double>(type: "float", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DobavljacNarudzbaStavke", x => x.DobavljacNarudzbaStavkeId);
                    table.ForeignKey(
                        name: "FK_DobavljacNarudzbaStavke_Artikal_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikal",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DobavljacNarudzbaStavke_DobavljacNarudzba_DobavljacNarudzbaId",
                        column: x => x.DobavljacNarudzbaId,
                        principalTable: "DobavljacNarudzba",
                        principalColumn: "DobavljacNarudzbaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorpaArtikli",
                columns: table => new
                {
                    KorpaArtikliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorpaId = table.Column<int>(type: "int", nullable: false),
                    ArtikalId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorpaArtikli", x => x.KorpaArtikliId);
                    table.ForeignKey(
                        name: "FK_KorpaArtikli_Artikal_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikal",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorpaArtikli_Korpa_KorpaId",
                        column: x => x.KorpaId,
                        principalTable: "Korpa",
                        principalColumn: "KorpaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavke",
                columns: table => new
                {
                    NarudzbaStavkeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtikalId = table.Column<int>(type: "int", nullable: false),
                    KupacNarudzbeId = table.Column<int>(type: "int", nullable: false),
                    RacunId = table.Column<int>(type: "int", nullable: false),
                    UnitCijena = table.Column<double>(type: "float", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    Popust = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavke", x => x.NarudzbaStavkeId);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Artikal_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikal",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_KupacNarudzbe_KupacNarudzbeId",
                        column: x => x.KupacNarudzbeId,
                        principalTable: "KupacNarudzbe",
                        principalColumn: "KupacNarudzbeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Racun_RacunId",
                        column: x => x.RacunId,
                        principalTable: "Racun",
                        principalColumn: "RacunId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtikalServis",
                columns: table => new
                {
                    ArtikalServisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarudzbaStavkeId = table.Column<int>(type: "int", nullable: false),
                    ServiserNaziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumPrijema = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumZavrsetka = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtikalServis", x => x.ArtikalServisId);
                    table.ForeignKey(
                        name: "FK_ArtikalServis_NarudzbaStavke_NarudzbaStavkeId",
                        column: x => x.NarudzbaStavkeId,
                        principalTable: "NarudzbaStavke",
                        principalColumn: "NarudzbaStavkeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikal_KategorijaId",
                table: "Artikal",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Artikal_ProizvodjacId",
                table: "Artikal",
                column: "ProizvodjacId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtikalPonuda_PonudaId",
                table: "ArtikalPonuda",
                column: "PonudaId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtikalServis_NarudzbaStavkeId",
                table: "ArtikalServis",
                column: "NarudzbaStavkeId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacijskiToken_KorisnickiNalogId",
                table: "AutorizacijskiToken",
                column: "KorisnickiNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Dobavljac_GradId",
                table: "Dobavljac",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_DobavljacNarudzba_DobavljacId",
                table: "DobavljacNarudzba",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_DobavljacNarudzbaStavke_ArtikalId",
                table: "DobavljacNarudzbaStavke",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_DobavljacNarudzbaStavke_DobavljacNarudzbaId",
                table: "DobavljacNarudzbaStavke",
                column: "DobavljacNarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_KantonId",
                table: "Grad",
                column: "KantonId");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KupacId",
                table: "Korpa",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_KorpaArtikli_ArtikalId",
                table: "KorpaArtikli",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_KorpaArtikli_KorpaId",
                table: "KorpaArtikli",
                column: "KorpaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_GradId",
                table: "Kupac",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_KorisnickiNalogId",
                table: "Kupac",
                column: "KorisnickiNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_KupacNarudzbe_GradId",
                table: "KupacNarudzbe",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_KupacNarudzbe_KupacId",
                table: "KupacNarudzbe",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_ArtikalId",
                table: "NarudzbaStavke",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_KupacNarudzbeId",
                table: "NarudzbaStavke",
                column: "KupacNarudzbeId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_RacunId",
                table: "NarudzbaStavke",
                column: "RacunId");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_UposlenikId",
                table: "Novosti",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_UposlenikId",
                table: "Racun",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_ArtikalId",
                table: "Recenzija",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_KupacId",
                table: "Recenzija",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_GradId",
                table: "Uposlenik",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_KorisnickiNalogId",
                table: "Uposlenik",
                column: "KorisnickiNalogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtikalPonuda");

            migrationBuilder.DropTable(
                name: "ArtikalServis");

            migrationBuilder.DropTable(
                name: "AutorizacijskiToken");

            migrationBuilder.DropTable(
                name: "DobavljacNarudzbaStavke");

            migrationBuilder.DropTable(
                name: "KorpaArtikli");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Ponuda");

            migrationBuilder.DropTable(
                name: "NarudzbaStavke");

            migrationBuilder.DropTable(
                name: "DobavljacNarudzba");

            migrationBuilder.DropTable(
                name: "Korpa");

            migrationBuilder.DropTable(
                name: "Artikal");

            migrationBuilder.DropTable(
                name: "KupacNarudzbe");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Dobavljac");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Proizvodjac");

            migrationBuilder.DropTable(
                name: "Kupac");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "KorisnickiNalog");

            migrationBuilder.DropTable(
                name: "Kanton");
        }
    }
}
