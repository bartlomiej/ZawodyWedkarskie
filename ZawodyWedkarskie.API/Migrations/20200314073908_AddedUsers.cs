using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZawodyWedkarskie.API.Migrations
{
    public partial class AddedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "KolaWedkarskie",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Uzytkownicy",
                columns: table => new
                {
                    IdUzytkownika = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwisko = table.Column<string>(type: "NVARCHAR(40)", nullable: false),
                    Imie = table.Column<string>(type: "NVARCHAR(30)", nullable: false),
                    Login = table.Column<string>(type: "NVARCHAR(70)", nullable: true),
                    Haslo = table.Column<byte[]>(nullable: true),
                    Sol = table.Column<byte[]>(nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Aktywny = table.Column<bool>(nullable: false),
                    UzytkownikUtworzyl = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    UzytkownikModyfikowal = table.Column<string>(type: "NVARCHAR(70)", nullable: false),
                    DataUtworzenia = table.Column<DateTime>(nullable: false),
                    DataModyfikacji = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzytkownicy", x => x.IdUzytkownika);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uzytkownicy");

            migrationBuilder.AlterColumn<string>(
                name: "Nazwa",
                table: "KolaWedkarskie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
