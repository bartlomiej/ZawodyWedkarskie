using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZawodyWedkarskie.API.Migrations
{
    public partial class Dodaniekilkutabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrandPrixy",
                columns: table => new
                {
                    IdGrandPrix = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(nullable: true),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrandPrixy", x => x.IdGrandPrix);
                });

            migrationBuilder.CreateTable(
                name: "Stanowiska",
                columns: table => new
                {
                    IdGrandPrix = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(nullable: true),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stanowiska", x => x.IdGrandPrix);
                });

            migrationBuilder.CreateTable(
                name: "Wedkarze",
                columns: table => new
                {
                    IdWedkarza = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NrKartyWedkarskiej = table.Column<string>(type: "NVARCHAR(20)", nullable: true),
                    Nazwisko = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Imie = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    ImieDrugie = table.Column<string>(type: "NVARCHAR(30)", nullable: true),
                    UprawnieniaSedziego = table.Column<bool>(nullable: false),
                    IdKola = table.Column<int>(nullable: false),
                    IdStanowiska = table.Column<int>(nullable: false),
                    Aktywny = table.Column<bool>(nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wedkarze", x => x.IdWedkarza);
                    table.ForeignKey(
                        name: "FK_Wedkarze_Kola_IdKola",
                        column: x => x.IdKola,
                        principalTable: "Kola",
                        principalColumn: "IdKola",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wedkarze_Stanowiska_IdStanowiska",
                        column: x => x.IdStanowiska,
                        principalTable: "Stanowiska",
                        principalColumn: "IdGrandPrix",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wedkarze_IdKola",
                table: "Wedkarze",
                column: "IdKola");

            migrationBuilder.CreateIndex(
                name: "IX_Wedkarze_IdStanowiska",
                table: "Wedkarze",
                column: "IdStanowiska");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrandPrixy");

            migrationBuilder.DropTable(
                name: "Wedkarze");

            migrationBuilder.DropTable(
                name: "Stanowiska");
        }
    }
}
