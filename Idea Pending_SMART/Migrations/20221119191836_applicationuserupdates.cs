using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class applicationuserupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Income",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Military",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Residence",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zip",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "b891609d-8b0c-45bb-a388-281db222f7d4", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f18654c0-ebaf-4421-9dc5-c1f1f4a3ae28", "SocialWorker", "SOCIALWORKER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "1c4a55d9-03a9-488a-9f84-a5d14caa2407", "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ApplicationUserId", "BirthDate", "City", "ConcurrencyStamp", "County", "Discriminator", "Education", "Email", "EmailConfirmed", "FirstName", "Gender", "Income", "LastName", "LockoutEnabled", "LockoutEnd", "Military", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "Race", "Residence", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb5", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb5", new DateTime(2022, 11, 19, 12, 18, 36, 152, DateTimeKind.Local).AddTicks(3130), "Jonestown", "d77eb279-8287-4fe1-a914-2684f3d7615b", "Davis", "ApplicationUser", "", "Instructor2@Instructor2.com", false, "MrTeacher", "", "", "MrTeacher", false, null, "", "Instructor2@Instructor2.COM", "Instructor2@Instructor2.COM", "AQAAAAEAACcQAAAAELrbIn4c5hd1N/sPa83XenB/qJS3JSuZ0IsyIP26RPK/bkje8Q6CL63cdsnt0DPd6Q==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Instructor2@Instructor2.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb6", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb6", new DateTime(2022, 11, 19, 12, 18, 36, 146, DateTimeKind.Local).AddTicks(7407), "Jonestown", "f57d3766-ceb2-4fb9-bbd3-c7080e147700", "Davis", "ApplicationUser", "", "Instructor1@Instructor1.com", false, "Gob", "", "", "Gobbo", false, null, "", "Instructor1@Instructor1.COM", "Instructor1@Instructor1.COM", "AQAAAAEAACcQAAAAEIw4twkL9qZD0gQP2Qaws0PgI+knT0ZbO5WsOoY84MSdPiOFVMcf26wEFqZwCkZp2g==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Instructor1@Instructor1.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb7", new DateTime(2022, 11, 19, 12, 18, 36, 141, DateTimeKind.Local).AddTicks(3049), "Jonestown", "ce7a621d-bb50-4f7a-8005-2f89e7729501", "Davis", "ApplicationUser", "", "SocialWorker2@SocialWorker2.com", false, "Miachael", "", "", "Bluth", false, null, "", "SocialWorker2@SocialWorker2.COM", "SocialWorker2@SocialWorker2.COM", "AQAAAAEAACcQAAAAEAEwMI7WXQ/Q6U1dsM24WXNDITvwxfI9DscRJZIC9TfOKE66DscYtk0o8nPNqcmDrQ==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "SocialWorker2@SocialWorker2.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "1234423312 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb8", new DateTime(2022, 11, 19, 12, 18, 36, 135, DateTimeKind.Local).AddTicks(8531), "Jonestown22", "1115bd64-1fbb-4fec-a88f-77bcdfcc2f43", "111111Davis", "ApplicationUser", "", "SocialWorker1@SocialWorker1.com", false, "Bob", "", "", "Propane", false, null, "", "SOCIALWORKER1@SOCIALWORKER1.COM", "SocialWorker1SocialWorker1.com", "AQAAAAEAACcQAAAAEGPATsaVsXlof5BDP2BkdipYOhKxN0uq3PBWu/P1TPNmhpF4cUnZSASYZdNdIBzT9w==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "SocialWorker1SocialWorker1.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb9", new DateTime(2022, 11, 19, 12, 18, 36, 130, DateTimeKind.Local).AddTicks(2174), "Jonestown", "1f07cc76-cfbe-4e3c-b4e6-6350a9606bd2", "Davis", "ApplicationUser", "", "Admin@Admin.com", false, "Hank", "", "", "Hill", false, null, "", "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEP+WgGZEZ5YJ0sEakrro3Ce2BNyZfoGWRHcg0jwtDjvI2jxYJutaPpM7C6wdsU9Mvw==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Admin@Admin.com", "84040" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8e445865-a24d-4543-a6c6-9443d048cdb5" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8e445865-a24d-4543-a6c6-9443d048cdb6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8e445865-a24d-4543-a6c6-9443d048cdb5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7212", "8e445865-a24d-4543-a6c6-9443d048cdb6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8e445865-a24d-4543-a6c6-9443d048cdb8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7212");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "County",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Education",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Income",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Military",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Residence",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "AspNetUsers");
        }
    }
}
