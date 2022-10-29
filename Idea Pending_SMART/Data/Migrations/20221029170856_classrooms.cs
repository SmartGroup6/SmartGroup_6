using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Data.Migrations
{
    public partial class classrooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    ClassroomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ClassDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentCount = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    ClassTimeID = table.Column<int>(type: "int", nullable: false),
                    SemesterID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.ClassroomID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classroom");
        }
    }
}
