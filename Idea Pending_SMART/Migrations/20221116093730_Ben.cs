using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class Ben : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicScore = table.Column<float>(type: "real", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationNameFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationNameLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Financials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeterminationNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstructorScore = table.Column<int>(type: "int", nullable: false),
                    SocialWorkerScore = table.Column<int>(type: "int", nullable: false),
                    AdminScore = table.Column<int>(type: "int", nullable: false),
                    TotalScore = table.Column<int>(type: "int", nullable: false),
                    SubmissionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChoppaTransportNeeded = table.Column<bool>(type: "bit", nullable: false),
                    MealsNeeded = table.Column<bool>(type: "bit", nullable: false),
                    ApplicantID = table.Column<int>(type: "int", nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");
        }
    }
}
