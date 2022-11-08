using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class chantel4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropColumn(
                name: "ApplicationID",
                table: "Applicant");

            migrationBuilder.AddColumn<float>(
                name: "AcademicScore",
                table: "Students",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "AdminScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationNameFirst",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationNameLast",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ChoppaTransportNeeded",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeterminationNote",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DistanceNote",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Financials",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InstructorScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "MealsNeeded",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SocialWorkerScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubmissionDate",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TotalScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicScore",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AdminScore",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ApplicationNameFirst",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ApplicationNameLast",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ChoppaTransportNeeded",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeterminationNote",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DistanceNote",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Financials",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InstructorScore",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MealsNeeded",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SocialWorkerScore",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SubmissionDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TotalScore",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationID",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicScore = table.Column<float>(type: "real", nullable: false),
                    AdminScore = table.Column<int>(type: "int", nullable: false),
                    ApplicantID = table.Column<int>(type: "int", nullable: false),
                    ApplicationNameFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationNameLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChoppaTransportNeeded = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeterminationNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Financials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstructorScore = table.Column<int>(type: "int", nullable: false),
                    MealsNeeded = table.Column<bool>(type: "bit", nullable: false),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    SocialWorkerScore = table.Column<int>(type: "int", nullable: false),
                    SubmissionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationID);
                });
        }
    }
}
