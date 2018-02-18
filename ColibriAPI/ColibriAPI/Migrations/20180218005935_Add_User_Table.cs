using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ColibriAPI.Migrations
{
    public partial class Add_User_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    CreatedByUser = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    DateDeleted = table.Column<DateTimeOffset>(nullable: true),
                    DateUpdated = table.Column<DateTimeOffset>(nullable: true),
                    DeletedByUser = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UpdatedByUser = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
