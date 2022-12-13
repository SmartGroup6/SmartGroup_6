using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class testApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicantID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SponsorID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InstructorScore",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "SocialWorkerScore",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "AcademicScore",
                table: "Applications",
                newName: "InitialScore");

            migrationBuilder.AlterColumn<int>(
                name: "TotalScore",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SubmissionDate",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SocialWorkerScore",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorScore",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "GPA",
                table: "Students",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Financials",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DistanceNote",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DeterminationNote",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationNameFirst",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminScore",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "AcademicScore",
                table: "Students",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "TotalScore",
                table: "Applications",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<float>(
                name: "AdminScore",
                table: "Applications",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationStatus",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b3a695cf-d9c7-40b9-b92c-c0581645dbeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "8cb047a2-e46c-45a2-93ae-f0514f634f8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "025dc9d3-df05-4d7b-bbc3-001c9e8d4420");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 12, 13, 2, 10, 26, 226, DateTimeKind.Local).AddTicks(2977), "59937c90-f763-4b2f-a17c-450d28c7a80a", "AQAAAAEAACcQAAAAEK3Kmo+HVKvdcCQWSsB0HVEwKz1CKXlstWFAT3DqHjatC2kCLClvdX0YZ0E1rncGUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 12, 13, 2, 10, 26, 223, DateTimeKind.Local).AddTicks(5556), "632d0428-27ac-43d7-a56e-ae0eb3583dbe", "AQAAAAEAACcQAAAAEG1xzl/0E8in1IhekERLz3nKD5cAisKc4GgFXaF6TP+2sNxPF5IvNzOf6OuXXhZKlA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 12, 13, 2, 10, 26, 222, DateTimeKind.Local).AddTicks(110), "6e8acbea-3409-4084-95d3-9fa98990454c", "AQAAAAEAACcQAAAAEHF0CepVDe4vMR4NeVxJDXUC8jPNnA1TzhUebhYYW8SZB1cy+ySry1iVMM6V0agnxw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 12, 13, 2, 10, 26, 220, DateTimeKind.Local).AddTicks(4613), "44a412c4-66f7-43d9-be02-6afc7dcfa906", "AQAAAAEAACcQAAAAEC+V0Bt/J7khAzjPJe6b7usDcbz0r2ewdIB2hijW2+07dXv/4cGxZuff7JXAGu+PgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 12, 13, 2, 10, 26, 218, DateTimeKind.Local).AddTicks(8662), "e1be1fbf-04f9-4af9-a35a-feeeb3de2125", "AQAAAAEAACcQAAAAEDD9r1/4O6mESksHMNoJAOHJ53ip0UN8ge8u6eXjcS9mHNPJEaZaw/tI3Isr/33EPg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicationStatus",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "InitialScore",
                table: "Applications",
                newName: "AcademicScore");

            migrationBuilder.AlterColumn<int>(
                name: "TotalScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubmissionDate",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SocialWorkerScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GPA",
                table: "Students",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Financials",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DistanceNote",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeterminationNote",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationNameFirst",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AdminScore",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "AcademicScore",
                table: "Students",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicantID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SponsorID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalScore",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdminScore",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorScore",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocialWorkerScore",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "d18abb8f-48e0-47f6-8445-cc06b470c691");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "2765d2aa-b049-41c8-88f5-c713d4b227e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "5f0811e7-df4f-4009-bb8c-235ffa90f0c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 16, 25, 33, 220, DateTimeKind.Local).AddTicks(4948), "69d0622c-9470-477a-929b-53d0dfcaea6b", "AQAAAAEAACcQAAAAEGLGTXEd6d7hjHjeP1Bc4UUn6RY/hAPJuUvUQyGCQNw2jeayMRoc9WX2DwVN3WkBWA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 16, 25, 33, 214, DateTimeKind.Local).AddTicks(9316), "1fb99bae-6ed2-439c-99b5-510ac9b6b008", "AQAAAAEAACcQAAAAEGVxFurUD8NSyhliPH92jx7nu332EeL4oOwQzF1qsU3Lp/Hgbo5AV6iQsX8CuAMhiQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 16, 25, 33, 209, DateTimeKind.Local).AddTicks(869), "9cb31087-f2e5-47c6-8378-5629b9838f51", "AQAAAAEAACcQAAAAENBKIoRziytBVOo0CGLND3o3R9hcJ57KUv338ug54kDxVirjzM832hUbYqowxNdlAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 16, 25, 33, 203, DateTimeKind.Local).AddTicks(972), "5a566849-a7d8-4ade-9e9e-35e1022a5f8a", "AQAAAAEAACcQAAAAEN+lHJr7/Zeg6F5iWYtMcPzxqGD2Q8I2xMi29m9YZYQWPqxag61206Gw0OXyApTJpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 16, 25, 33, 196, DateTimeKind.Local).AddTicks(9720), "66cd61d0-ddfe-465b-a6d5-9dd21c616be6", "AQAAAAEAACcQAAAAEApm0Z+OG0qdnkVAUq4Yn2ciN4K1L0lui0k5yOZCLIhkGQBPS7Vkfvd9FIs2n9HoBg==" });
        }
    }
}
