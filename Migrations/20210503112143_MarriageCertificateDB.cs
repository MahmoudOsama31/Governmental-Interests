using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class MarriageCertificateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarriageCertificate",
                columns: table => new
                {
                    MarriageCertificateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    FirstMotherName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Governorate = table.Column<string>(nullable: true),
                    region = table.Column<string>(nullable: true),
                    NumberOfCopies = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    GrandpaName = table.Column<string>(nullable: true),
                    FamilyName = table.Column<string>(nullable: true),
                    SecondMotherName = table.Column<string>(nullable: true),
                    CardId = table.Column<string>(nullable: true),
                    HusbandOrwifeName = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    PaymentType = table.Column<string>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    OrderType = table.Column<string>(nullable: true),
                    Confirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarriageCertificate", x => x.MarriageCertificateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarriageCertificate");
        }
    }
}
