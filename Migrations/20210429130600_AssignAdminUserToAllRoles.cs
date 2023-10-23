using Microsoft.EntityFrameworkCore.Migrations;

namespace GI.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("  insert into [dbo].[AspNetUserRoles] (UserId,RoleId) select '1137edb5-869b-4496-b16d-53c5726e5c10',Id from [dbo].[AspNetRoles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUserRoles] WHERE UserId = '1137edb5-869b-4496-b16d-53c5726e5c10'");
        }
    }
}
