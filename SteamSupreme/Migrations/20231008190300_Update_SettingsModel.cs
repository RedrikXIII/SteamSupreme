using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SteamSupreme.Migrations
{
    public partial class Update_SettingsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_SettingsModel_SettingsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SettingsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SettingsId",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SettingsModel",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SettingsModel_UserId",
                table: "SettingsModel",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SettingsModel_Users_UserId",
                table: "SettingsModel",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SettingsModel_Users_UserId",
                table: "SettingsModel");

            migrationBuilder.DropIndex(
                name: "IX_SettingsModel_UserId",
                table: "SettingsModel");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SettingsModel");

            migrationBuilder.AddColumn<Guid>(
                name: "SettingsId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_SettingsId",
                table: "Users",
                column: "SettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_SettingsModel_SettingsId",
                table: "Users",
                column: "SettingsId",
                principalTable: "SettingsModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
