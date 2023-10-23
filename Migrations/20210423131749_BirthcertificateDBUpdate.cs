using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class BirthcertificateDBUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Birthcertificates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Birthcertificates",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Birthcertificates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OrderType",
                table: "Birthcertificates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "OrderType",
                table: "Birthcertificates");
        }
    }
}
