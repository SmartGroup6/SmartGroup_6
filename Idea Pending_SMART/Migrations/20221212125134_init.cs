﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    ApplicantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.ApplicantID);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicScore = table.Column<float>(type: "real", nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationNameFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationNameLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Financials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeterminationNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistanceNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstructorScore = table.Column<int>(type: "int", nullable: true),
                    SocialWorkerScore = table.Column<int>(type: "int", nullable: true),
                    AdminScore = table.Column<int>(type: "int", nullable: true),
                    TotalScore = table.Column<int>(type: "int", nullable: true),
                    SubmissionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChoppaTransportNeeded = table.Column<bool>(type: "bit", nullable: true),
                    MealsNeeded = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Income = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Residence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Military = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealProvided = table.Column<bool>(type: "bit", nullable: false),
                    MealEaten = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.AttendanceID);
                });

            migrationBuilder.CreateTable(
                name: "ClassTimes",
                columns: table => new
                {
                    ClassTimeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStart = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTimes", x => x.ClassTimeID);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionsName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionsID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartmentNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressGPSLatitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressGPSLongitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressState = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    SchoolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    SponsorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DonationTotal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.SponsorID);
                });

            migrationBuilder.CreateTable(
                name: "StudentNote",
                columns: table => new
                {
                    StudentNoteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentNote", x => x.StudentNoteID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timeAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CurrentGrade = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SponsorID = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    SemesterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActiveSemester = table.Column<bool>(type: "bit", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true),
                    MaxStudentCount = table.Column<int>(type: "int", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.SemesterID);
                    table.ForeignKey(
                        name: "FK_Semester_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "SchoolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Studentcount = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    ClassTimeID = table.Column<int>(type: "int", nullable: false),
                    SemesterID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_Class_ClassTimes_ClassTimeID",
                        column: x => x.ClassTimeID,
                        principalTable: "ClassTimes",
                        principalColumn: "ClassTimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Course_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Semester_SemesterID",
                        column: x => x.SemesterID,
                        principalTable: "Semester",
                        principalColumn: "SemesterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentIssuetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignmentDueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClassID = table.Column<int>(type: "int", nullable: true),
                    AssignmentTotalMarks = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.AssignmentID);
                    table.ForeignKey(
                        name: "FK_Assignment_Class_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Class",
                        principalColumn: "ClassID");
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    EnrollmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => new { x.StudentID, x.ClassID });
                    table.ForeignKey(
                        name: "FK_Enrollments_Class_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Class",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "5c507e12-4ca9-4976-b87b-8b243257725d", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3a627e7a-1c22-4de5-ac09-65c5ffb02d94", "SocialWorker", "SOCIALWORKER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "100f8201-0abd-498e-beb5-b5393b36448f", "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ApplicationUserId", "BirthDate", "City", "ConcurrencyStamp", "County", "Discriminator", "Education", "Email", "EmailConfirmed", "FirstName", "Gender", "Income", "LastName", "LockoutEnabled", "LockoutEnd", "Military", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "Race", "Residence", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb5", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb5", new DateTime(2022, 12, 12, 5, 51, 34, 111, DateTimeKind.Local).AddTicks(3539), "Jonestown", "bc641e2b-2a51-4a01-9d2b-5503068da01b", "Davis", "ApplicationUser", "", "Instructor2@Instructor2.com", false, "MrTeacher", "", "", "MrTeacher", false, null, "", "Instructor2@Instructor2.COM", "Instructor2@Instructor2.COM", "AQAAAAEAACcQAAAAEMoxzz1odyMbM9uvSzflGRefcBD0Cqw+qpEX7gnANtSuA8uHRAWtIeTc1sQfIloAng==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Instructor2@Instructor2.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb6", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb6", new DateTime(2022, 12, 12, 5, 51, 34, 105, DateTimeKind.Local).AddTicks(7649), "Jonestown", "3f3fbe4c-4d10-4d86-b524-1918e0e76b82", "Davis", "ApplicationUser", "", "Instructor1@Instructor1.com", false, "Gob", "", "", "Gobbo", false, null, "", "Instructor1@Instructor1.COM", "Instructor1@Instructor1.COM", "AQAAAAEAACcQAAAAEGewdvUxm1GGtOjNruolMlnUtgK5/Ulr+YL+x2efYSR8HDug98pw3NjY6dy0CJorfw==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Instructor1@Instructor1.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb7", new DateTime(2022, 12, 12, 5, 51, 34, 100, DateTimeKind.Local).AddTicks(3103), "Jonestown", "80cb0ca3-48f8-4efb-a14a-a840f160195d", "Davis", "ApplicationUser", "", "SocialWorker2@SocialWorker2.com", false, "Miachael", "", "", "Bluth", false, null, "", "SocialWorker2@SocialWorker2.COM", "SocialWorker2@SocialWorker2.COM", "AQAAAAEAACcQAAAAEKZTJ+5fX/5gWDyQp27AX9D4boebrvR8tb2DKpIT7oJr/1MT3W7Xriw2Z1cFMldMVg==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "SocialWorker2@SocialWorker2.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "1234423312 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb8", new DateTime(2022, 12, 12, 5, 51, 34, 94, DateTimeKind.Local).AddTicks(8329), "Jonestown22", "a3506d8c-8e18-4e6d-9592-f247faaf0ee9", "111111Davis", "ApplicationUser", "", "SocialWorker1@SocialWorker1.com", false, "Bob", "", "", "Propane", false, null, "", "SOCIALWORKER1@SOCIALWORKER1.COM", "SocialWorker1SocialWorker1.com", "AQAAAAEAACcQAAAAEIxowiiKXAk5POoJzEAsv1YNIi4SXM4ra54MwKPU++xdIobN83tc4rH9Kjutj5TtjA==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "SocialWorker1SocialWorker1.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb9", new DateTime(2022, 12, 12, 5, 51, 34, 89, DateTimeKind.Local).AddTicks(1019), "Jonestown", "e1ee6e72-a5eb-468b-95b6-6edb2339bbc4", "Davis", "ApplicationUser", "", "Admin@Admin.com", false, "Hank", "", "", "Hill", false, null, "", "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKr9v0rRHV6ap7RXGiB2hbjk53PGObyuVihsvNVhRZS4Yy0VAKNFGc5nWVix+enw5g==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Admin@Admin.com", "84040" }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_ClassID",
                table: "Assignment",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_ClassTimeID",
                table: "Class",
                column: "ClassTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_CourseID",
                table: "Class",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_SemesterID",
                table: "Class",
                column: "SemesterID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_ClassID",
                table: "Enrollments",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SchoolId",
                table: "Semester",
                column: "SchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Sponsor");

            migrationBuilder.DropTable(
                name: "StudentNote");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassTimes");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
