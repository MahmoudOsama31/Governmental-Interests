using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class updatephoto2DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo2",
                table: "RegisterCivil",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Photo2",
                table: "RegisterCivil",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }
    }
}
