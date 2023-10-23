using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class AddCoulmnInBirthCertificateOrderDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "Birthcertificates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kind",
                table: "Birthcertificates",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "Birthcertificates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "Kind",
                table: "Birthcertificates");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "Birthcertificates");
        }
    }
}
