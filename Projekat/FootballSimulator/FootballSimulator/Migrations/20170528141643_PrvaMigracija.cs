using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballSimulator.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezultat",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Domaci = table.Column<int>(nullable: false),
                    Gosti = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezultat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistike",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Bodovi = table.Column<int>(nullable: false),
                    Pobjede = table.Column<int>(nullable: false),
                    Porazi = table.Column<int>(nullable: false),
                    PostignutiGolovi = table.Column<int>(nullable: false),
                    PrimljeniGolovi = table.Column<int>(nullable: false),
                    Remi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistike", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sezone",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MojKlub = table.Column<int>(nullable: false),
                    TrenutnoKolo = table.Column<int>(nullable: false),
                    VlasnikSezoneId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sezone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kola",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Odigrano = table.Column<bool>(nullable: false),
                    RedniBroj = table.Column<int>(nullable: false),
                    SezonaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kola", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timovi",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Formacija = table.Column<string>(nullable: true),
                    KapitenId = table.Column<string>(nullable: true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Igraci",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Godine = table.Column<int>(nullable: false),
                    Att = table.Column<int>(nullable: false),
                    Mid = table.Column<int>(nullable: false),
                    Def = table.Column<int>(nullable: false),
                    Gk = table.Column<int>(nullable: false),
                    CleanSheet = table.Column<int>(nullable: true),
                    PostignutiGolovi = table.Column<int>(nullable: true),
                    Stamina = table.Column<int>(nullable: false),
                    Suspendovan = table.Column<bool>(nullable: true),
                    TimId = table.Column<int>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igraci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klubovi",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    EkipaId = table.Column<string>(nullable: true),
                    Racun = table.Column<double>(nullable: false),
                    SezonaId = table.Column<string>(nullable: true),
                    StatistikaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klubovi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utakmice",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DomaciId = table.Column<string>(nullable: true),
                    GostiId = table.Column<string>(nullable: true),
                    KoloId = table.Column<string>(nullable: true),
                    Odigrana = table.Column<bool>(nullable: false),
                    RezultatId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utakmice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UtakmicaIgrac",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UtakmicaId = table.Column<string>(nullable: true),
                    IgracId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtakmicaIgrac", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UtakmicaIgrac_UtakmicaId",
                table: "UtakmicaIgrac",
                column: "UtakmicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Igraci_TimId",
                table: "Igraci",
                column: "TimId");

            migrationBuilder.CreateIndex(
                name: "IX_Klubovi_EkipaId",
                table: "Klubovi",
                column: "EkipaId");

            migrationBuilder.CreateIndex(
                name: "IX_Klubovi_SezonaId",
                table: "Klubovi",
                column: "SezonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Klubovi_StatistikaId",
                table: "Klubovi",
                column: "StatistikaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kola_SezonaId",
                table: "Kola",
                column: "SezonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sezone_VlasnikSezoneId",
                table: "Sezone",
                column: "VlasnikSezoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Timovi_KapitenId",
                table: "Timovi",
                column: "KapitenId");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_DomaciId",
                table: "Utakmice",
                column: "DomaciId");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_GostiId",
                table: "Utakmice",
                column: "GostiId");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_KoloId",
                table: "Utakmice",
                column: "KoloId");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmice_RezultatId",
                table: "Utakmice",
                column: "RezultatId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UtakmicaIgrac");

            migrationBuilder.DropTable(
                name: "Klubovi");

            migrationBuilder.DropTable(
                name: "Utakmice");

            migrationBuilder.DropTable(
                name: "Statistike");

            migrationBuilder.DropTable(
                name: "Kola");

            migrationBuilder.DropTable(
                name: "Rezultat");

            migrationBuilder.DropTable(
                name: "Sezone");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Timovi");

            migrationBuilder.DropTable(
                name: "Igraci");
        }
    }
}
