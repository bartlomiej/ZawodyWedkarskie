using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZawodyWedkarskie.API.Migrations
{
    public partial class Tworzeniebazy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kola",
                columns: table => new
                {
                    IdKola = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: true),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kola", x => x.IdKola);
                });

            migrationBuilder.CreateTable(
                name: "Uzytkownicy",
                columns: table => new
                {
                    IdUzytkownika = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwisko = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Imie = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    NrKartyWedkarskiej = table.Column<string>(type: "NVARCHAR(30)", nullable: true),
                    Login = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    HasloHash = table.Column<byte[]>(nullable: false),
                    HasloSalt = table.Column<byte[]>(nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Aktywny = table.Column<bool>(nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataModyfikacji = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownicy", x => x.IdUzytkownika);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kola");

            migrationBuilder.DropTable(
                name: "Uzytkownicy");
        }
    }
}
