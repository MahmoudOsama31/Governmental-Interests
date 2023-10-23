using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class BirthcertificateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birthcertificates",
                columns: table => new
                {
                    BirthcertificateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    ApartmentNumber = table.Column<int>(nullable: false),
                    FloorNumber = table.Column<int>(nullable: false),
                    HomeNumber = table.Column<int>(nullable: false),
                    StreetName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    Governorate = table.Column<string>(nullable: true),
                    PoliceDepartment = table.Column<string>(nullable: true),
                    NumberOfCopies = table.Column<int>(nullable: false),
                    DegreeOfKinship = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    GrandpaName = table.Column<string>(nullable: true),
                    FamilyName = table.Column<string>(nullable: true),
                    CardId = table.Column<string>(nullable: true),
                    PaymentType = table.Column<string>(nullable: true),
                    photo1 = table.Column<byte[]>(nullable: true),
                    photo2 = table.Column<byte[]>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birthcertificates", x => x.BirthcertificateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birthcertificates");
        }
    }
}
