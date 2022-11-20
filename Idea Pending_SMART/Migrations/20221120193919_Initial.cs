using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignmentDescription",
                table: "Assignment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Assignment",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MealsNeeded",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
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

            migrationBuilder.AlterColumn<bool>(
                name: "ChoppaTransportNeeded",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "GPA",
                table: "Applications",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Applications",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "74bd83bb-0f53-43fb-b1c3-962efea4068c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "9de057b9-50aa-426b-86dc-53cbd482b9e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "fe90b0df-c37a-46fd-8eeb-84fd83248bd6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 12, 39, 18, 362, DateTimeKind.Local).AddTicks(3813), "ee7ea91d-5e28-4d1e-8a89-29146b82645c", "AQAAAAEAACcQAAAAEEpolxIXiVXxZUZsqN+LDnCUYIt12niMOaSDwHp2CIBuXxVQDnu+cM+xZtok6TqGqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 12, 39, 18, 351, DateTimeKind.Local).AddTicks(2693), "08c05ee8-a799-4582-a3bf-921f7d0a6601", "AQAAAAEAACcQAAAAEFeu9ylnuTYQ0WzU1EMbZ7Xw/gIRaYwIHUrPND5c1UW6fGPgVkdGS+TMPibkBx/jBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 12, 39, 18, 340, DateTimeKind.Local).AddTicks(2085), "3d28daca-9b3f-4b6d-8088-9265b3cc593f", "AQAAAAEAACcQAAAAEIJJ5s5Zj4tv/0bQmYlkGdrln3w7Ts61jRN1YLIyopKOw76Dm5vZSKxfmNo77d/2XA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 12, 39, 18, 329, DateTimeKind.Local).AddTicks(5969), "f1b242c5-64a4-499c-b0ad-deee2e613279", "AQAAAAEAACcQAAAAED7DiYC5sfvWVadT6IlG0qXNqly4i4b9/kzGn1G+MeiuZKabiWnJyAs8paJ3kdCNMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 12, 39, 18, 318, DateTimeKind.Local).AddTicks(9327), "60cbaa36-d1e2-423d-abf8-19bc8bf45683", "AQAAAAEAACcQAAAAEJffO3QIJekzfhH6rZwO+SwULwkXMjJcZGYsCRAVu5Uz+rKMtnEpBhhf0Nj9+7NNWQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_ClassID",
                table: "Assignment",
                column: "ClassID");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Class_ClassID",
                table: "Assignment",
                column: "ClassID",
                principalTable: "Class",
                principalColumn: "ClassID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Class_ClassID",
                table: "Assignment");

            migrationBuilder.DropIndex(
                name: "IX_Assignment_ClassID",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "AssignmentDescription",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "GPA",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Applications");

            migrationBuilder.AlterColumn<bool>(
                name: "MealsNeeded",
                table: "Applications",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "ChoppaTransportNeeded",
                table: "Applications",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b891609d-8b0c-45bb-a388-281db222f7d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "f18654c0-ebaf-4421-9dc5-c1f1f4a3ae28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "1c4a55d9-03a9-488a-9f84-a5d14caa2407");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 18, 36, 152, DateTimeKind.Local).AddTicks(3130), "d77eb279-8287-4fe1-a914-2684f3d7615b", "AQAAAAEAACcQAAAAELrbIn4c5hd1N/sPa83XenB/qJS3JSuZ0IsyIP26RPK/bkje8Q6CL63cdsnt0DPd6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 18, 36, 146, DateTimeKind.Local).AddTicks(7407), "f57d3766-ceb2-4fb9-bbd3-c7080e147700", "AQAAAAEAACcQAAAAEIw4twkL9qZD0gQP2Qaws0PgI+knT0ZbO5WsOoY84MSdPiOFVMcf26wEFqZwCkZp2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 18, 36, 141, DateTimeKind.Local).AddTicks(3049), "ce7a621d-bb50-4f7a-8005-2f89e7729501", "AQAAAAEAACcQAAAAEAEwMI7WXQ/Q6U1dsM24WXNDITvwxfI9DscRJZIC9TfOKE66DscYtk0o8nPNqcmDrQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 18, 36, 135, DateTimeKind.Local).AddTicks(8531), "1115bd64-1fbb-4fec-a88f-77bcdfcc2f43", "AQAAAAEAACcQAAAAEGPATsaVsXlof5BDP2BkdipYOhKxN0uq3PBWu/P1TPNmhpF4cUnZSASYZdNdIBzT9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 19, 12, 18, 36, 130, DateTimeKind.Local).AddTicks(2174), "1f07cc76-cfbe-4e3c-b4e6-6350a9606bd2", "AQAAAAEAACcQAAAAEP+WgGZEZ5YJ0sEakrro3Ce2BNyZfoGWRHcg0jwtDjvI2jxYJutaPpM7C6wdsU9Mvw==" });
        }
    }
}
