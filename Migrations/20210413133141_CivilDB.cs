using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class CivilDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderCivil");

            migrationBuilder.CreateTable(
                name: "RegisterCivil",
                columns: table => new
                {
                    OrderCivilId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardID = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    governorate = table.Column<string>(nullable: true),
                    region = table.Column<string>(nullable: true),
                    card_type = table.Column<string>(nullable: true),
                    service_type = table.Column<string>(nullable: true),
                    payment_method = table.Column<string>(nullable: true),
                    Photos = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterCivil", x => x.OrderCivilId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterCivil");

            migrationBuilder.CreateTable(
                name: "OrderCivil",
                columns: table => new
                {
                    OrderCivilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    card_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    governorate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCivil", x => x.OrderCivilId);
                });
        }
    }
}
