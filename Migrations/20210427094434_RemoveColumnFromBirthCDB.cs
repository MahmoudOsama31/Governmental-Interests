using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class RemoveColumnFromBirthCDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentNumber",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "FloorNumber",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "HomeNumber",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "PoliceDepartment",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Birthcertificates");

           

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Birthcertificates",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Birthcertificates");

            

            migrationBuilder.AddColumn<int>(
                name: "ApartmentNumber",
                table: "Birthcertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Birthcertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FloorNumber",
                table: "Birthcertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeNumber",
                table: "Birthcertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PoliceDepartment",
                table: "Birthcertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PostalCode",
                table: "Birthcertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Birthcertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
