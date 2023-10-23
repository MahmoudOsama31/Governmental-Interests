using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class AddCoulmnInCardOrderDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "RegisterCivil",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Kind",
                table: "RegisterCivil",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Religion",
                table: "RegisterCivil",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialStatus",
                table: "RegisterCivil",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qualification",
                table: "RegisterCivil",
                nullable: true);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "RegisterCivil");

            migrationBuilder.DropColumn(
                name: "Kind",
                table: "RegisterCivil");

            migrationBuilder.DropColumn(
                name: "Religion",
                table: "RegisterCivil");

            migrationBuilder.DropColumn(
                name: "SocialStatus",
                table: "RegisterCivil");

            migrationBuilder.DropColumn(
                name: "qualification",
                table: "RegisterCivil");

           
        }
    }
}
