using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZawodyWedkarskie.API.Migrations
{
    public partial class ModyfikacjatabeliUzytkownicy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Haslo",
                table: "Uzytkownicy");

            migrationBuilder.DropColumn(
                name: "Sol",
                table: "Uzytkownicy");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Uzytkownicy",
                type: "NVARCHAR(70)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(70)",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "HasloHash",
                table: "Uzytkownicy",
                nullable: false,
                defaultValue: new byte[] {  });

            migrationBuilder.AddColumn<byte[]>(
                name: "HasloSalt",
                table: "Uzytkownicy",
                nullable: false,
                defaultValue: new byte[] {  });

            migrationBuilder.AddColumn<string>(
                name: "NrKartyWedkarskiej",
                table: "Uzytkownicy",
                type: "NVARCHAR(30)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasloHash",
                table: "Uzytkownicy");

            migrationBuilder.DropColumn(
                name: "HasloSalt",
                table: "Uzytkownicy");

            migrationBuilder.DropColumn(
                name: "NrKartyWedkarskiej",
                table: "Uzytkownicy");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Uzytkownicy",
                type: "NVARCHAR(70)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(70)");

            migrationBuilder.AddColumn<byte[]>(
                name: "Haslo",
                table: "Uzytkownicy",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Sol",
                table: "Uzytkownicy",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
