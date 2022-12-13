using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Idea_Pending_SMART.Migrations
{
    public partial class beta_noApp1 : Migration
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
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationNameFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationNameLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPA = table.Column<float>(type: "real", nullable: false),
                    Financials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeterminationNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistanceNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InitialScore = table.Column<float>(type: "real", nullable: true),
                    AdminScore = table.Column<float>(type: "real", nullable: true),
                    TotalScore = table.Column<float>(type: "real", nullable: true),
                    ApplicationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChoppaTransportNeeded = table.Column<bool>(type: "bit", nullable: false),
                    MealsNeeded = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Assignment",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignmentIssuetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignmentDueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignmentTotalMarks = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.AssignmentID);
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
                    student_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    class_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    PermissionsName = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    AcademicScore = table.Column<float>(type: "real", nullable: true),
                    timeAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CurrentGrade = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SponsorID = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationNameFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationNameLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPA = table.Column<float>(type: "real", nullable: false),
                    Financials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeterminationNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistanceNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstructorScore = table.Column<int>(type: "int", nullable: true),
                    SocialWorkerScore = table.Column<int>(type: "int", nullable: true),
                    AdminScore = table.Column<int>(type: "int", nullable: true),
                    TotalScore = table.Column<int>(type: "int", nullable: true),
                    SubmissionDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_IdentityRoleId",
                        column: x => x.IdentityRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionsID",
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
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassID);
                    table.ForeignKey(
                        name: "FK_Class_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "707c3527-9137-4ebf-a295-d3dc6eee1ea8", "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0adf7f80-4474-4559-8d7f-367c468be8d7", "SocialWorker", "SOCIALWORKER" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7212", "7cec9971-1acc-41fc-b448-bc5dade6c341", "Instructor", "INSTRUCTOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ApplicationUserId", "BirthDate", "City", "ConcurrencyStamp", "County", "Discriminator", "Education", "Email", "EmailConfirmed", "FirstName", "Gender", "Income", "LastName", "LockoutEnabled", "LockoutEnd", "Military", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "Race", "Residence", "SecurityStamp", "State", "StreetAddress", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb5", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb5", new DateTime(2022, 12, 13, 10, 16, 16, 714, DateTimeKind.Local).AddTicks(6743), "Jonestown", "56c189f9-c3eb-4113-8934-5196f6a60920", "Davis", "ApplicationUser", "", "Instructor2@Instructor2.com", false, "MrTeacher", "", "", "MrTeacher", false, null, "", "Instructor2@Instructor2.COM", "Instructor2@Instructor2.COM", "AQAAAAEAACcQAAAAELLVp37XyL/mP645/eeFB4ClMHN/ds5JoVdqC7os6khy7JFzvkBTY5YZDovazCF3sw==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Instructor2@Instructor2.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb6", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb6", new DateTime(2022, 12, 13, 10, 16, 16, 713, DateTimeKind.Local).AddTicks(3533), "Jonestown", "5b982316-38c0-4889-9740-e9dc20e3e4cc", "Davis", "ApplicationUser", "", "Instructor1@Instructor1.com", false, "Gob", "", "", "Gobbo", false, null, "", "Instructor1@Instructor1.COM", "Instructor1@Instructor1.COM", "AQAAAAEAACcQAAAAEJw8uoq9p5qFe0Ls20aOegW5RAg0f/hJ6Q2SCMrRIu9pAqspPu9plvEAXU14TBPu2g==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Instructor1@Instructor1.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb7", new DateTime(2022, 12, 13, 10, 16, 16, 712, DateTimeKind.Local).AddTicks(280), "Jonestown", "044d2c3e-b761-47b5-977d-637a09b9e340", "Davis", "ApplicationUser", "", "SocialWorker2@SocialWorker2.com", false, "Miachael", "", "", "Bluth", false, null, "", "SocialWorker2@SocialWorker2.COM", "SocialWorker2@SocialWorker2.COM", "AQAAAAEAACcQAAAAEKB9QigK3DiVVE5XYmSM7ev7q2D91cxPVnbn7tWDU+e58hUss2Txmi7/5GzV2gZ7YA==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "SocialWorker2@SocialWorker2.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "1234423312 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb8", new DateTime(2022, 12, 13, 10, 16, 16, 710, DateTimeKind.Local).AddTicks(7268), "Jonestown22", "abce28a0-6f15-46f2-b804-8fabedff0a22", "111111Davis", "ApplicationUser", "", "SocialWorker1@SocialWorker1.com", false, "Bob", "", "", "Propane", false, null, "", "SOCIALWORKER1@SOCIALWORKER1.COM", "SocialWorker1SocialWorker1.com", "AQAAAAEAACcQAAAAEHiSuMmHMbyH5TbZR9gng7XAnEV0WRowzvThU5wou94fcVoIWbnosBIDu98e7mIWNw==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "SocialWorker1SocialWorker1.com", "84040" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "123 Flicka Flacka Way", "8e445865-a24d-4543-a6c6-9443d048cdb9", new DateTime(2022, 12, 13, 10, 16, 16, 709, DateTimeKind.Local).AddTicks(4511), "Jonestown", "2c9b837c-ec12-48c9-851a-75e780d76f7f", "Davis", "ApplicationUser", "", "Admin@Admin.com", false, "Hank", "", "", "Hill", false, null, "", "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFxjwbzBsjNEuXu/zJe1QjTPSEgzSh/TNLPtoXxfLMFkQgup/+07IMOX8J1MzS4U9Q==", "800calladmin", false, "84040", "", "", "6d4fb098-23b1-4219-8b4c-c146830ede28", "Texas", "123 Flicka Flacka Way", false, "Admin@Admin.com", "84040" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionsID", "PermissionsName" },
                values: new object[,]
                {
                    { 1, "CanEditUsers" },
                    { 2, "CanViewApplications" },
                    { 3, "CanEditApplications" },
                    { 4, "CanReviewApplications" },
                    { 5, "CanEditRoles" },
                    { 6, "CanViewSemesters" },
                    { 7, "CanEditSemesters" },
                    { 8, "CanCreateSemesters" },
                    { 9, "CanSocialworkerStuff" },
                    { 10, "CanInstructorStuff" }
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

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "IdentityRoleId", "PermissionsId" },
                values: new object[,]
                {
                    { 1, "2c5e174e-3b0e-446f-86af-483d56fd7210", 1 },
                    { 2, "2c5e174e-3b0e-446f-86af-483d56fd7210", 2 },
                    { 3, "2c5e174e-3b0e-446f-86af-483d56fd7210", 3 },
                    { 4, "2c5e174e-3b0e-446f-86af-483d56fd7210", 4 },
                    { 5, "2c5e174e-3b0e-446f-86af-483d56fd7211", 1 },
                    { 6, "2c5e174e-3b0e-446f-86af-483d56fd7211", 2 },
                    { 7, "2c5e174e-3b0e-446f-86af-483d56fd7211", 3 },
                    { 8, "2c5e174e-3b0e-446f-86af-483d56fd7211", 4 },
                    { 9, "2c5e174e-3b0e-446f-86af-483d56fd7212", 1 },
                    { 10, "2c5e174e-3b0e-446f-86af-483d56fd7212", 2 },
                    { 11, "2c5e174e-3b0e-446f-86af-483d56fd7212", 3 },
                    { 12, "2c5e174e-3b0e-446f-86af-483d56fd7212", 4 },
                    { 13, "2c5e174e-3b0e-446f-86af-483d56fd7210", 5 },
                    { 14, "2c5e174e-3b0e-446f-86af-483d56fd7210", 6 },
                    { 15, "2c5e174e-3b0e-446f-86af-483d56fd7210", 7 },
                    { 16, "2c5e174e-3b0e-446f-86af-483d56fd7210", 8 },
                    { 17, "2c5e174e-3b0e-446f-86af-483d56fd7211", 9 },
                    { 18, "2c5e174e-3b0e-446f-86af-483d56fd7212", 10 }
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
                name: "IX_Class_ApplicationUserId",
                table: "Class",
                column: "ApplicationUserId");

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
                name: "IX_RolePermissions_IdentityRoleId",
                table: "RolePermissions",
                column: "IdentityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionsId",
                table: "RolePermissions",
                column: "PermissionsId");

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
                name: "Person");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Sponsor");

            migrationBuilder.DropTable(
                name: "StudentNote");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
