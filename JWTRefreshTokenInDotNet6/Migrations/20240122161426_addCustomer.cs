﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JWTRefreshTokenInDotNet6.Migrations
{
    public partial class addCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO [dbo].[AspNetRoles] VALUES ('{Guid.NewGuid()}', 'Customer', 'CUSTOMER', '{Guid.NewGuid()}')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"DELETE FROM [dbo].[AspNetRoles] WHERE Name = 'Customer'");
        }
    }
}