using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamSupreme.Migrations
{
    public partial class Add_Companies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_CompanyModel_CompanyId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyModel",
                table: "CompanyModel");

            migrationBuilder.RenameTable(
                name: "CompanyModel",
                newName: "Companies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Companies_CompanyId",
                table: "Games",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Companies_CompanyId",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "CompanyModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyModel",
                table: "CompanyModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_CompanyModel_CompanyId",
                table: "Games",
                column: "CompanyId",
                principalTable: "CompanyModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
