using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class CivilUpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photos",
                table: "RegisterCivil");

            migrationBuilder.AddColumn<string>(
                name: "Photo1",
                table: "RegisterCivil",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo2",
                table: "RegisterCivil",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo1",
                table: "RegisterCivil");

            migrationBuilder.DropColumn(
                name: "Photo2",
                table: "RegisterCivil");

            migrationBuilder.AddColumn<string>(
                name: "Photos",
                table: "RegisterCivil",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
