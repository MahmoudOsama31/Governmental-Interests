using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class CardLoginID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardLoginID",
                table: "Birthcertificates",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardLoginID",
                table: "Birthcertificates");
        }
    }
}
