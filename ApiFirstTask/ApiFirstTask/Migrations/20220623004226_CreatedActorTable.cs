using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFirstTask.Migrations
{
    public partial class CreatedActorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 255, nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    CreatedTime = table.Column<DateTime>(nullable: false, defaultValueSql: "GETUTCDATE()"),
                    ModifiedTime = table.Column<DateTime>(nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");
        }
    }
}
