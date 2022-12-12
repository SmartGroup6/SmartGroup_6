using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class Assignment : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "0a3728b4-0d87-4ae0-8494-a76254ea8484");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "00fc14c4-2d9b-4570-92cd-a20709c45043");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212",
                column: "ConcurrencyStamp",
                value: "f22c3d52-d887-45c1-9820-8f6ca78485ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 22, 15, 106, DateTimeKind.Local).AddTicks(5853), "6873e960-b1fe-44a2-9d57-9d933d0724ec", "AQAAAAEAACcQAAAAEClvz2fKzTPviLc8opX6jFU2sALljv4QyGNjVs/FIFxwgFk7AiLTRc1SrmpVoN90HA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 22, 15, 98, DateTimeKind.Local).AddTicks(8259), "5a5ea17a-7b14-48dd-8d44-ad38efec10c4", "AQAAAAEAACcQAAAAED9kBv1aq8zZot2LNuIEuJQ7n2MAOPAU0XqCRC7P9bG+fPTcUibQUdH6vKOIFvpuNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 22, 15, 92, DateTimeKind.Local).AddTicks(1745), "6802442a-caa1-48b9-a469-dfc146c7b9e6", "AQAAAAEAACcQAAAAEItsLAn0Lcp2OW1igksijUqQtFUV4OBlEq7RjqQqYaegEoj2j0sQyjwRBwGIVcJUew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 22, 15, 85, DateTimeKind.Local).AddTicks(1101), "6a113602-9ef1-4f4e-aade-770ed2f71c10", "AQAAAAEAACcQAAAAENNudrAlt2OpL/FPIS4QEBe818EUF577xTqhMkmIN4x9LGE7gP2RUMzaS+8ZVTQ8og==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { new DateTime(2022, 11, 20, 22, 22, 15, 78, DateTimeKind.Local).AddTicks(709), "bb24a57d-3e81-4a39-be3a-dd5dd62c33d6", "AQAAAAEAACcQAAAAEOmbBo+AbSN+WQnLS1lVMsV188+q4dErennOyc4vwFP6an/vqiAFysvKwTbOkVnpFQ==" });

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
