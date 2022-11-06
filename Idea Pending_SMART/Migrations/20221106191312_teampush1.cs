using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class teampush1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Applicant");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Attendance",
                newName: "EnrollmentID");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "StudentNote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SubmissionDate",
                table: "Application",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Application",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationNameFirst",
                table: "Application",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationNameLast",
                table: "Application",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Application",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "StudentNote");

            migrationBuilder.DropColumn(
                name: "ApplicationNameFirst",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "ApplicationNameLast",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Application");

            migrationBuilder.RenameColumn(
                name: "EnrollmentID",
                table: "Attendance",
                newName: "StudentID");

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Attendance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmissionDate",
                table: "Application",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Application",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Applicant",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
