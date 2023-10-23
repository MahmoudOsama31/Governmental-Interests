using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class AddColumnCivilDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "RegisterCivil",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "RegisterCivil",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OrderType",
                table: "RegisterCivil",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "RegisterCivil");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "RegisterCivil");

            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "RegisterCivil");
        }
    }
}
