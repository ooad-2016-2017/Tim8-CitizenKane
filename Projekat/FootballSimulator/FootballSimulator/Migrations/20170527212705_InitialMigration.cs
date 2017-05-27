using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FootballSimulator.Migrations
{
    public partial class InitialMigration : Migration
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
                name: "Sezone",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MojKlub = table.Column<int>(nullable: false),
                    TrenutnoKolo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sezone", x => x.Id);
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
                name: "Kola",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Odigrano = table.Column<bool>(nullable: false),
                    SezonaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kola", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kola_Sezone_SezonaId",
                        column: x => x.SezonaId,
                        principalTable: "Sezone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_Klubovi_Timovi_EkipaId",
                        column: x => x.EkipaId,
                        principalTable: "Timovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Klubovi_Sezone_SezonaId",
                        column: x => x.SezonaId,
                        principalTable: "Sezone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Klubovi_Statistike_StatistikaId",
                        column: x => x.StatistikaId,
                        principalTable: "Statistike",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_Utakmice_Timovi_DomaciId",
                        column: x => x.DomaciId,
                        principalTable: "Timovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utakmice_Timovi_GostiId",
                        column: x => x.GostiId,
                        principalTable: "Timovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utakmice_Kola_KoloId",
                        column: x => x.KoloId,
                        principalTable: "Kola",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utakmice_Rezultat_RezultatId",
                        column: x => x.RezultatId,
                        principalTable: "Rezultat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Igraci",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Att = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    CleanSheet = table.Column<int>(nullable: false),
                    Def = table.Column<int>(nullable: false),
                    Gk = table.Column<int>(nullable: false),
                    Godine = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Mid = table.Column<int>(nullable: false),
                    PostignutiGolovi = table.Column<int>(nullable: false),
                    Stamina = table.Column<int>(nullable: false),
                    Suspendovan = table.Column<bool>(nullable: false),
                    TimId = table.Column<string>(nullable: true),
                    TimId1 = table.Column<string>(nullable: true),
                    TimId2 = table.Column<string>(nullable: true),
                    UtakmicaId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igraci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Igraci_Timovi_TimId",
                        column: x => x.TimId,
                        principalTable: "Timovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Igraci_Timovi_TimId1",
                        column: x => x.TimId1,
                        principalTable: "Timovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Igraci_Timovi_TimId2",
                        column: x => x.TimId2,
                        principalTable: "Timovi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Igraci_Utakmice_UtakmicaId",
                        column: x => x.UtakmicaId,
                        principalTable: "Utakmice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Igraci_TimId",
                table: "Igraci",
                column: "TimId");

            migrationBuilder.CreateIndex(
                name: "IX_Igraci_TimId1",
                table: "Igraci",
                column: "TimId1");

            migrationBuilder.CreateIndex(
                name: "IX_Igraci_TimId2",
                table: "Igraci",
                column: "TimId2");

            migrationBuilder.CreateIndex(
                name: "IX_Igraci_UtakmicaId",
                table: "Igraci",
                column: "UtakmicaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Timovi_Igraci_KapitenId",
                table: "Timovi",
                column: "KapitenId",
                principalTable: "Igraci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Igraci_Timovi_TimId",
                table: "Igraci");

            migrationBuilder.DropForeignKey(
                name: "FK_Igraci_Timovi_TimId1",
                table: "Igraci");

            migrationBuilder.DropForeignKey(
                name: "FK_Igraci_Timovi_TimId2",
                table: "Igraci");

            migrationBuilder.DropForeignKey(
                name: "FK_Utakmice_Timovi_DomaciId",
                table: "Utakmice");

            migrationBuilder.DropForeignKey(
                name: "FK_Utakmice_Timovi_GostiId",
                table: "Utakmice");

            migrationBuilder.DropTable(
                name: "Klubovi");

            migrationBuilder.DropTable(
                name: "Statistike");

            migrationBuilder.DropTable(
                name: "Timovi");

            migrationBuilder.DropTable(
                name: "Igraci");

            migrationBuilder.DropTable(
                name: "Utakmice");

            migrationBuilder.DropTable(
                name: "Kola");

            migrationBuilder.DropTable(
                name: "Rezultat");

            migrationBuilder.DropTable(
                name: "Sezone");
        }
    }
}
