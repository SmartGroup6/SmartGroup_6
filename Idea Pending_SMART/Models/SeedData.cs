using Idea_Pending_SMART.Data;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Idea_Pending_SMART.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.School.Any())
            {
                context.School.AddRange(
                    new School
                    {
                        Phone = "",
                        SchoolName = "School One"
                    },
                    new School
                    {
                        Phone = "",
                        SchoolName = "School Two"
                    },
                    new School
                    {
                        Phone = "",
                        SchoolName = "Public School"

                    }

                    ); context.SaveChanges();
            }
            if (!context.Semester.Any())
            {
                context.Semester.AddRange(
                    new Semester
                    {
                        IsActiveSemester = true,
                        IsArchived = false,
                        EndDate = DateTime.Now,
                        MaxStudentCount = 200,
                        SchoolId = 1,
                        SemesterName = "2022 Winter",
                        StartDate = DateTime.Now

                    },
                    new Semester
                    {
                        IsActiveSemester = true,
                        IsArchived = false,
                        EndDate = DateTime.Now,
                        MaxStudentCount = 200,
                        SchoolId = 2,
                        SemesterName = "2022 Winter",
                        StartDate = DateTime.Now

                    }

                    ); context.SaveChanges();
            }
            if (!context.ClassTimes.Any())
            {
                context.ClassTimes.AddRange(
                    new ClassTime
                    {
                        Day = "Monday",
                        TimeStart = "9:00"
                    },
                    new ClassTime
                    {
                        Day = "Tuesday",
                        TimeStart = "11:00"
                    },
                    new ClassTime
                    {

                        Day = "Tuesday",
                        TimeStart = "8:00"
                    },
                    new ClassTime
                    {
                        Day = "Thursday",
                        TimeStart = "13:00"
                    },
                    new ClassTime
                    {
                        Day = "Friday",
                        TimeStart = "12:00"
                    }
                    ); context.SaveChanges();
            }
            //if (!context.User.Any())
            //{
            //    context.User.AddRange(
            //        new User
            //        {
            //            EmailAddress = "abc@gmail.com",
            //            Password = "password",
            //            PersonID = 6,
            //            RoleID = 2,
            //        },
            //        new User
            //        {
            //            EmailAddress = "abc@gmail.com",
            //            Password = "12345678",
            //            PersonID = 7,
            //            RoleID = 1,
            //        }

            //        ); context.SaveChanges();
            //}
            if (!context.Person.Any())
            {
                context.Person.AddRange(
                    new Person
                    {
                        AddressCity = "",
                        AddressGPSLatitude = "",
                        AddressGPSLongitude = "",
                        AddressState = "",
                        ApartmentNum = "",
                        StreetAddress = "",
                        FirstName = "Guardian ",
                        LastName = "One",
                        Phone = ""

                    },
                    new Person
                    {
                        AddressCity = "",
                        AddressGPSLatitude = "",
                        AddressGPSLongitude = "",
                        AddressState = "",
                        ApartmentNum = "",
                        StreetAddress = "",
                        FirstName = "Guardian ",
                        LastName = "Two",
                        Phone = ""

                    },
                    new Person
                    {
                        AddressCity = "",
                        AddressGPSLatitude = "",
                        AddressGPSLongitude = "",
                        AddressState = "",
                        ApartmentNum = "",
                        StreetAddress = "",
                        FirstName = "Guardian ",
                        LastName = "Three",
                        Phone = ""

                    },
                    new Person
                    {
                        AddressCity = "",
                        AddressGPSLatitude = "",
                        AddressGPSLongitude = "",
                        AddressState = "",
                        ApartmentNum = "",
                        StreetAddress = "",
                        FirstName = "Guardian ",
                        LastName = "Four",
                        Phone = ""

                    },
                    new Person
                    {
                        AddressCity = "",
                        AddressGPSLatitude = "",
                        AddressGPSLongitude = "",
                        AddressState = "",
                        ApartmentNum = "",
                        StreetAddress = "",
                        FirstName = "Guardian ",
                        LastName = "Five",
                        Phone = ""

                    },
                    new Person
                    {
                        AddressCity = "",
                        AddressGPSLatitude = "",
                        AddressGPSLongitude = "",
                        AddressState = "",
                        ApartmentNum = "",
                        StreetAddress = "",
                        FirstName = "Instructor ",
                        LastName = "One",
                        Phone = ""

                    },
                    new Person
                    {
                        AddressCity = "",
                        AddressGPSLatitude = "",
                        AddressGPSLongitude = "",
                        AddressState = "",
                        ApartmentNum = "",
                        StreetAddress = "",
                        FirstName = "Admin ",
                        LastName = "One",
                        Phone = ""

                    }

                    ); context.SaveChanges();
            }

            if (!context.Students.Any())
            {
                context.Students.AddRange(
                    new Student
                    {

                        timeAvailable = true,
                        CurrentGrade = 'B',
                        SponsorID = 1,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "One",
                        AcademicScore = 25,
                        DateOfBirth = "04/01/2008",
                        Financials = "500",
                        DeterminationNote = "very determined",
                        DistanceNote = "lives far",
                        AdminScore = 25,
                        InstructorScore = 25,
                        SocialWorkerScore = 25,
                        TotalScore = 100,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = true,
                        MealsNeeded = true,
                        ApplicantID = 1
                    },
                    new Student
                    {

                        timeAvailable = true,
                        CurrentGrade = 'A',
                        SponsorID = 1,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Two",
                        AcademicScore = 25,
                        DateOfBirth = "04/01/2009",
                        Financials = "5000",
                        DeterminationNote = "",
                        DistanceNote = "Lives close",
                        AdminScore = 25,
                        InstructorScore = 25,
                        SocialWorkerScore = 25,
                        TotalScore = 100,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = false,
                        MealsNeeded = true,
                        ApplicantID = 2
                    },
                    new Student
                    {

                        timeAvailable = false,
                        CurrentGrade = 'B',
                        SponsorID = 0,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Three",
                        AcademicScore = 0,
                        DateOfBirth = "04/01/2002",
                        Financials = "800",
                        DeterminationNote = "",
                        DistanceNote = "",
                        AdminScore = 0,
                        InstructorScore = 0,
                        SocialWorkerScore = 0,
                        TotalScore = 0,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = true,
                        MealsNeeded = true,
                        ApplicantID = 3
                    },
                    new Student
                    {

                        timeAvailable = false,
                        CurrentGrade = 'C',
                        SponsorID = 0,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Four",
                        AcademicScore = 5,
                        DateOfBirth = "04/01/2008",
                        Financials = "500",
                        DeterminationNote = "",
                        DistanceNote = "",
                        AdminScore = 20,
                        InstructorScore = 20,
                        SocialWorkerScore = 20,
                        TotalScore = 65,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = true,
                        MealsNeeded = true,
                        ApplicantID = 4
                    },
                    new Student
                    {

                        timeAvailable = true,
                        CurrentGrade = 'B',
                        SponsorID = 3,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Five",
                        AcademicScore = 20,
                        DateOfBirth = "04/01/2008",
                        Financials = "500",
                        DeterminationNote = "",
                        DistanceNote = "",
                        AdminScore = 20,
                        InstructorScore = 20,
                        SocialWorkerScore = 20,
                        TotalScore = 80,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = false,
                        MealsNeeded = false,
                        ApplicantID = 5
                    }

                    ); context.SaveChanges();
            }
            // test application seed data (for demonstration, same as student)
         /*   if (!context.Applications.Any())
            {
                context.Applications.AddRange(
                    new Application
                    {

                        //SponsorID = 1,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "One",
                        GPA = 20,
                        AcademicScore = 25,
                        DateOfBirth = "2008-04-01",
                        Financials = "Less than 10,200 MZN",
                        DeterminationNote = "very determined",
                        DistanceNote = "lives far",
                        AdminScore = 25,
                        InstructorScore = 25,
                        SocialWorkerScore = 25,
                        TotalScore = 100,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = true,
                        MealsNeeded = true,
                        IsActive = true,
                        //ApplicantID = 1
                    },
                    new Application
                    {

                        //SponsorID = 1,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Two",
                        GPA = 20,
                        AcademicScore = 25,
                        DateOfBirth = "04/01/2009",
                        Financials = "Less than 10,200 MZN",
                        DeterminationNote = "",
                        DistanceNote = "Lives close",
                        AdminScore = 25,
                        InstructorScore = 25,
                        SocialWorkerScore = 25,
                        TotalScore = 100,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = false,
                        MealsNeeded = true,
                        IsActive= false,
                        //ApplicantID = 2
                    },
                    new Application
                    {
                       // SponsorID = 0,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Three",
                        GPA = 20,
                        AcademicScore = 0,
                        DateOfBirth = "04/01/2002",
                        Financials = "Less than 10,200 MZN",
                        DeterminationNote = "",
                        DistanceNote = "",
                        AdminScore = 0,
                        InstructorScore = 0,
                        SocialWorkerScore = 0,
                        TotalScore = 0,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = true,
                        MealsNeeded = true,
                        IsActive = false,
                       // ApplicantID = 3
                    },
                    new Application
                    {

                        //SponsorID = 0,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Four",
                        GPA = 20,
                        AcademicScore = 5,
                        DateOfBirth = "04/01/2008",
                        Financials = "Less than 10,200 MZN",
                        DeterminationNote = "",
                        DistanceNote = "",
                        AdminScore = 20,
                        InstructorScore = 20,
                        SocialWorkerScore = 20,
                        TotalScore = 65,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = true,
                        MealsNeeded = true,
                        IsActive=false,
                       // ApplicantID = 4
                    },
                    new Application
                    {

                        //SponsorID = 3,
                        ApplicationNameFirst = "Student",
                        ApplicationNameLast = "Five",
                        GPA = 20,
                        AcademicScore = 20,
                        DateOfBirth = "04/01/2008",
                        Financials = "Less than 10,200 MZN",
                        DeterminationNote = "",
                        DistanceNote = "",
                        AdminScore = 20,
                        InstructorScore = 20,
                        SocialWorkerScore = 20,
                        TotalScore = 80,
                        SubmissionDate = "11/06/2022",
                        ChoppaTransportNeeded = false,
                        MealsNeeded = false,
                        IsActive=true
                        //ApplicantID = 5
                    }

                    ); context.SaveChanges();
            }*/
            if (!context.Applicant.Any())
            {
                context.Applicant.AddRange(
                    new Applicant
                    {
                        AppStatus = "Active"
                    },
                    new Applicant
                    {
                        AppStatus = "Active"
                    },
                    new Applicant
                    {
                        AppStatus = "Not Active"
                    },
                    new Applicant
                    {
                        AppStatus = "Active"
                    },
                    new Applicant
                    {
                        AppStatus = "Active"
                    }

                    ); context.SaveChanges();
            }

            if (!context.Course.Any())
            {
                context.Course.AddRange(
                    new Course
                    {
                        CourseDescription = "IT Level 1",
                        SchoolId = 2,
                        CourseName = "Intro to computers"

                    },
                    new Course
                    {
                        CourseDescription = "IT Level 1",
                        SchoolId = 1,
                        CourseName = "Intro to computers"

                    },
                    new Course
                    {
                        CourseDescription = "IT Level 3",
                        SchoolId = 2,
                        CourseName = "Advanced IT"

                    },
                    new Course
                    {
                        CourseDescription = "English Level 2",
                        SchoolId = 1,
                        CourseName = "Intermediate English"

                    },
                    new Course
                    {
                        CourseDescription = "English Level 2",
                        SchoolId = 2,
                        CourseName = "Intermediate English"

                    },
                    new Course
                    {
                        CourseDescription = "Public school, hours unavailable for student",
                        SchoolId = 3,
                        CourseName = "Public Class Block"
                    }
                    ); context.SaveChanges();
            }

            if (!context.Class.Any())
            {
                context.Class.AddRange(
                    new Class
                    {
                        ClassDescription = "Morning English Level 2",
                        ClassTimeID = 1,
                        CourseID = 4,
                        SemesterID = 1,
                        Studentcount = 15,
                        UserID = 1
                    },
                    new Class
                    {
                        ClassDescription = "Afternoon IT Level 2",
                        ClassTimeID = 2,
                        CourseID = 2,
                        SemesterID = 1,
                        Studentcount = 10,
                        UserID = 2
                    },
                    new Class
                    {
                        ClassDescription = "Morning IT Level 1",
                        ClassTimeID = 3,
                        CourseID = 1,
                        SemesterID = 2,
                        Studentcount = 12,
                        UserID = 1
                    },
                    new Class
                    {
                        ClassDescription = "Late English Level 2",
                        ClassTimeID = 4,
                        CourseID = 5,
                        SemesterID = 2,
                        Studentcount = 20,
                        UserID = 2
                    },
                    new Class
                    {
                        ClassDescription = "Public School",
                        ClassTimeID = 3,
                        CourseID = 6,
                        SemesterID = 2,
                        Studentcount = 200,
                        UserID = null
                    }

                    ); context.SaveChanges();
            }

            if (!context.Attendance.Any())
            {
                context.Attendance.AddRange(
                    new Attendance
                    {
                        EnrollmentID = 1,
                        Date = DateTime.Now,
                        MealProvided = true,
                        MealEaten = 'Y'

                    },
                    new Attendance
                    {
                        EnrollmentID = 1,
                        Date = DateTime.Now,
                        MealProvided = false,
                        MealEaten = 'N'

                    },
                    new Attendance
                    {
                        EnrollmentID = 2,
                        Date = DateTime.Now,
                        MealProvided = false,
                        MealEaten = 'N'

                    },
                    new Attendance
                    {
                        EnrollmentID = 3,
                        Date = DateTime.Now,
                        MealProvided = true,
                        MealEaten = 'N'
                    },
                    new Attendance
                    {
                        EnrollmentID = 4,
                        Date = DateTime.Now,
                        MealProvided = true,
                        MealEaten = 'Y'

                    },
                    new Attendance
                    {
                        EnrollmentID = 5,
                        Date = DateTime.Now,
                        MealProvided = true,
                        MealEaten = 'N'
                    }

                    ); context.SaveChanges();
            }

            if (!context.Permissions.Any())
            {
                context.Permissions.AddRange(
                    new Permissions
                    {
                        PermissionsName = "Administrator"
                    },
                    new Permissions
                    {
                        PermissionsName = "Instructor"
                    },
                    new Permissions
                    {
                        PermissionsName = "Social Worker"
                    }

                    ); context.SaveChanges();
            }
            if(!context.Assignment.Any())
            {
                context.Assignment.AddRange(
                    new Assignment
                    {
                        AssignmentName = "Quiz Week 1",
                        AssignmentIssuetDate = DateTime.Now,
                        AssignmentDueDate = DateTime.Today,
                        AssignmentTotalMarks = 100,
                    }
                    ); context.SaveChanges() ;
            }

            

 
            if (!context.Sponsor.Any())
            {
                context.Sponsor.AddRange(
                    new Sponsor
                    {
                        CompanyName = "Guardian One",
                        DonationTotal = "2,000",
                        PersonID = 1
                    },
                    new Sponsor
                    {
                        CompanyName = "Guardian Four",
                        DonationTotal = "200",
                        PersonID = 4
                    },
                    new Sponsor
                    {
                        CompanyName = "Guardian Two",
                        DonationTotal = "500",
                        PersonID = 2
                    }

                    ); context.SaveChanges();
            }
            if (!context.StudentNote.Any())
            {
                context.StudentNote.AddRange(
                    new StudentNote
                    {

                        DateCreated = DateTime.Now,
                        Text = "abc xyz",
                        StudentID = 1
                    },
                    new StudentNote
                    {

                        DateCreated = DateTime.Now,
                        Text = "abc xyz",
                        StudentID = 2
                    },
                    new StudentNote
                    {

                        DateCreated = DateTime.Now,
                        Text = "abc xyz",
                        StudentID = 1
                    },
                    new StudentNote
                    {

                        DateCreated = DateTime.Now,
                        Text = "abc xyz",
                        StudentID = 3
                    }

                    ); context.SaveChanges();

            }
            if (!context.Enrollments.Any())
            {
                context.Enrollments.AddRange(
                    new Enrollment
                    {
                        ClassID = 4,
                        StudentID = 3
                    },
                    new Enrollment
                    {
                        ClassID = 2,
                        StudentID = 2
                    },
                    new Enrollment
                    {
                        ClassID = 3,
                        StudentID = 3
                    },
                    new Enrollment
                    {
                        ClassID = 3,
                        StudentID = 1
                    },
                   new Enrollment
                   {
                       ClassID = 2,
                       StudentID = 3
                   },
                   new Enrollment
                   {
                       ClassID = 3,
                       StudentID = 4
                   },
                   new Enrollment
                   {
                       ClassID = 5,
                       StudentID = 5
                   }
                    ); context.SaveChanges();
            }


        }

    }
}
