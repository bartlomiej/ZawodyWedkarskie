using Microsoft.EntityFrameworkCore.Migrations;

namespace ZawodyWedkarskie.API.Migrations
{
    public partial class Poprawawtabeliwedkarze : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wedkarze_Kola_IdKola",
                table: "Wedkarze");

            migrationBuilder.DropForeignKey(
                name: "FK_Wedkarze_Stanowiska_IdStanowiska",
                table: "Wedkarze");

            migrationBuilder.AlterColumn<int>(
                name: "IdStanowiska",
                table: "Wedkarze",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdKola",
                table: "Wedkarze",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Wedkarze_Kola_IdKola",
                table: "Wedkarze",
                column: "IdKola",
                principalTable: "Kola",
                principalColumn: "IdKola",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wedkarze_Stanowiska_IdStanowiska",
                table: "Wedkarze",
                column: "IdStanowiska",
                principalTable: "Stanowiska",
                principalColumn: "IdGrandPrix",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wedkarze_Kola_IdKola",
                table: "Wedkarze");

            migrationBuilder.DropForeignKey(
                name: "FK_Wedkarze_Stanowiska_IdStanowiska",
                table: "Wedkarze");

            migrationBuilder.AlterColumn<int>(
                name: "IdStanowiska",
                table: "Wedkarze",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdKola",
                table: "Wedkarze",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Wedkarze_Kola_IdKola",
                table: "Wedkarze",
                column: "IdKola",
                principalTable: "Kola",
                principalColumn: "IdKola",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wedkarze_Stanowiska_IdStanowiska",
                table: "Wedkarze",
                column: "IdStanowiska",
                principalTable: "Stanowiska",
                principalColumn: "IdGrandPrix",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
