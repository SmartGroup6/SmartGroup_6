using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class chantel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Class",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Class");
        }
    }
}
