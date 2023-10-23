using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class dateUpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "RegisterCivil");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "RegisterCivil",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "RegisterCivil",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "RegisterCivil",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
