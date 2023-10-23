﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace GI.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                 columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                 values: new object[] { Guid.NewGuid().ToString(), "User", "User", Guid.NewGuid().ToString() },
                 schema: "dbo"
             );
            migrationBuilder.InsertData(
    table: "AspNetRoles",
     columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
     values: new object[] { Guid.NewGuid().ToString(), "Admin", "Admin", Guid.NewGuid().ToString() },
     schema: "dbo"
 );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetRoles]");
        }
    }
}
