using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZawodyWedkarskie.API.Migrations
{
    public partial class Aktualkzacjacontextu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wedkarze_Stanowiska_IdStanowiska",
                table: "Wedkarze");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stanowiska",
                table: "Stanowiska");

            migrationBuilder.RenameTable(
                name: "Stanowiska",
                newName: "SlownikStanowiska");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SlownikStanowiska",
                table: "SlownikStanowiska",
                column: "IdGrandPrix");

            migrationBuilder.CreateTable(
                name: "SlownikGatunkiRyb",
                columns: table => new
                {
                    IdGatunku = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    WymiarOchronny = table.Column<int>(nullable: false),
                    Punkty = table.Column<int>(nullable: false),
                    PunktyPonadWymiar = table.Column<int>(nullable: false),
                    OkresOchronnyOd = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    OkresOchronnyDo = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlownikGatunkiRyb", x => x.IdGatunku);
                });

            migrationBuilder.CreateTable(
                name: "SlownikLowiska",
                columns: table => new
                {
                    IdLowiska = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlownikLowiska", x => x.IdLowiska);
                });

            migrationBuilder.CreateTable(
                name: "SlownikNagrody",
                columns: table => new
                {
                    IdNagrody = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    SredniaCena = table.Column<decimal>(type: "MONEY", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlownikNagrody", x => x.IdNagrody);
                });

            migrationBuilder.CreateTable(
                name: "SlownikRodzajeZawodow",
                columns: table => new
                {
                    IdRodzaju = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rodzaj = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    Dyscyplina = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlownikRodzajeZawodow", x => x.IdRodzaju);
                });

            migrationBuilder.CreateTable(
                name: "UzytkownikyUprawnienia",
                columns: table => new
                {
                    IdUprawnienia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUzytkownika = table.Column<int>(nullable: false),
                    Klucz = table.Column<string>(type: "NVARCHAR(6)", nullable: false),
                    Uprawnienie = table.Column<string>(type: "NVARCHAR(1)", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UzytkownikyUprawnienia", x => x.IdUprawnienia);
                    table.ForeignKey(
                        name: "FK_UzytkownikyUprawnienia_Uzytkownicy_IdUzytkownika",
                        column: x => x.IdUzytkownika,
                        principalTable: "Uzytkownicy",
                        principalColumn: "IdUzytkownika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zawody",
                columns: table => new
                {
                    IdZawodow = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    Data = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataKoncaZapisow = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataZbiorki = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataRozpoczecia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataZakonczenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    IdRodzajuZawodow = table.Column<int>(nullable: false),
                    IdGrandPrix = table.Column<int>(nullable: false),
                    IdKolaOrganizatora = table.Column<int>(nullable: false),
                    TylkoDlaCzlonkowKola = table.Column<bool>(nullable: false),
                    IdLowiska = table.Column<int>(nullable: false),
                    Zakonczone = table.Column<bool>(nullable: false),
                    UwagiLowisko = table.Column<string>(nullable: true),
                    Protesty = table.Column<string>(nullable: true),
                    PunktyZaWymiar = table.Column<int>(nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zawody", x => x.IdZawodow);
                    table.ForeignKey(
                        name: "FK_Zawody_GrandPrixy_IdGrandPrix",
                        column: x => x.IdGrandPrix,
                        principalTable: "GrandPrixy",
                        principalColumn: "IdGrandPrix",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zawody_Kola_IdKolaOrganizatora",
                        column: x => x.IdKolaOrganizatora,
                        principalTable: "Kola",
                        principalColumn: "IdKola",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zawody_SlownikLowiska_IdLowiska",
                        column: x => x.IdLowiska,
                        principalTable: "SlownikLowiska",
                        principalColumn: "IdLowiska",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zawody_SlownikRodzajeZawodow_IdRodzajuZawodow",
                        column: x => x.IdRodzajuZawodow,
                        principalTable: "SlownikRodzajeZawodow",
                        principalColumn: "IdRodzaju",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UzytkownikyUprawnienia_IdUzytkownika",
                table: "UzytkownikyUprawnienia",
                column: "IdUzytkownika");

            migrationBuilder.CreateIndex(
                name: "IX_Zawody_IdGrandPrix",
                table: "Zawody",
                column: "IdGrandPrix");

            migrationBuilder.CreateIndex(
                name: "IX_Zawody_IdKolaOrganizatora",
                table: "Zawody",
                column: "IdKolaOrganizatora");

            migrationBuilder.CreateIndex(
                name: "IX_Zawody_IdLowiska",
                table: "Zawody",
                column: "IdLowiska");

            migrationBuilder.CreateIndex(
                name: "IX_Zawody_IdRodzajuZawodow",
                table: "Zawody",
                column: "IdRodzajuZawodow");

            migrationBuilder.AddForeignKey(
                name: "FK_Wedkarze_SlownikStanowiska_IdStanowiska",
                table: "Wedkarze",
                column: "IdStanowiska",
                principalTable: "SlownikStanowiska",
                principalColumn: "IdGrandPrix",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wedkarze_SlownikStanowiska_IdStanowiska",
                table: "Wedkarze");

            migrationBuilder.DropTable(
                name: "SlownikGatunkiRyb");

            migrationBuilder.DropTable(
                name: "SlownikNagrody");

            migrationBuilder.DropTable(
                name: "UzytkownikyUprawnienia");

            migrationBuilder.DropTable(
                name: "Zawody");

            migrationBuilder.DropTable(
                name: "SlownikLowiska");

            migrationBuilder.DropTable(
                name: "SlownikRodzajeZawodow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SlownikStanowiska",
                table: "SlownikStanowiska");

            migrationBuilder.RenameTable(
                name: "SlownikStanowiska",
                newName: "Stanowiska");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stanowiska",
                table: "Stanowiska",
                column: "IdGrandPrix");

            migrationBuilder.AddForeignKey(
                name: "FK_Wedkarze_Stanowiska_IdStanowiska",
                table: "Wedkarze",
                column: "IdStanowiska",
                principalTable: "Stanowiska",
                principalColumn: "IdGrandPrix",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
