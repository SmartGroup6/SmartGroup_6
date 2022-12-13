using Idea_Pending_SMART.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Idea_Pending_SMART.Data
{
    public class DbContextSeeder
    {
        private List<String> universalPermissions;
        private List<String> adminPermissions;
        private List<String> socialPermissions;
        private List<String> instructorPermissions;
        public DbContextSeeder()
        {
            universalPermissions = new List<string>();
            adminPermissions = new List<string>();
            socialPermissions = new List<string>();
            instructorPermissions = new List<string>();
        }

        /// <summary>
        /// Creates Admin, Social Worker, Instructor roles
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void RolesSeeder(ModelBuilder modelBuilder)
        {
            //Seeding Roles to AspNetRoles table

            //admin
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                Name = "Admin",
                NormalizedName = "ADMIN",
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", 
                Name = "SocialWorker",
                NormalizedName = "SOCIALWORKER",
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                Name = "Instructor",
                NormalizedName = "INSTRUCTOR",
            });
        }
    
        /// <summary>
        /// Creates several users in the db to start, at least one for each role
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void UserSeeder(ModelBuilder modelBuilder)
        {
            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<ApplicationUser>();
            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<ApplicationUser>().HasData(

                //Admin
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // UNIQUE primary key
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",  //duplicated here
                    UserName = "Admin@Admin.com",
                    Email = "Admin@Admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    FirstName = "Hank",  //note specific fields may vary depending on how you extended the Identity model with your own user properties and fiels
                    LastName = "Hill",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",  //make anything up
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                },

                //SocialWorker1
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                    UserName = "SocialWorker1SocialWorker1.com",
                    Email = "SocialWorker1@SocialWorker1.com",
                    NormalizedEmail = "SOCIALWORKER1@SOCIALWORKER1.COM",
                    FirstName = "Bob",
                    LastName = "Propane",
                    Address = "1234423312 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown22",
                    County = "111111Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "SocialWorker1SocialWorker1.com",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                },

                //SocialWorker2
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb7",
                    UserName = "SocialWorker2@SocialWorker2.com",
                    Email = "SocialWorker2@SocialWorker2.com",
                    NormalizedEmail = "SocialWorker2@SocialWorker2.COM",
                    FirstName = "Miachael",
                    LastName = "Bluth",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "SocialWorker2@SocialWorker2.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                },

                //Instructor1
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb6",
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb6",
                    UserName = "Instructor1@Instructor1.com",
                    Email = "Instructor1@Instructor1.com",
                    NormalizedEmail = "Instructor1@Instructor1.COM",
                    FirstName = "Gob",
                    LastName = "Gobbo",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "Instructor1@Instructor1.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                },

                //Instructor2
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb5",
                    ApplicationUserId = "8e445865-a24d-4543-a6c6-9443d048cdb5",
                    UserName = "Instructor2@Instructor2.com",
                    Email = "Instructor2@Instructor2.com",
                    NormalizedEmail = "Instructor2@Instructor2.COM",
                    FirstName = "MrTeacher",
                    LastName = "MrTeacher",
                    Address = "123 Flicka Flacka Way",
                    StreetAddress = "123 Flicka Flacka Way",
                    City = "Jonestown",
                    County = "Davis",
                    Zip = "84040",
                    PostalCode = "84040",
                    PhoneNumber = "800calladmin",
                    PhoneNumberConfirmed = false,
                    Gender = "",
                    Race = "",
                    BirthDate = DateTime.Now,
                    Income = "",
                    Education = "",
                    Residence = "",
                    Military = "",
                    NormalizedUserName = "Instructor2@Instructor2.COM",
                    PasswordHash = hasher.HashPassword(null, "Temp1234$"),
                    EmailConfirmed = false,
                    SecurityStamp = "6d4fb098-23b1-4219-8b4c-c146830ede28",
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    State = "Texas",

                    AccessFailedCount = 0
                }
            );


            //Seeding the relation between our MANY users and and their MANY roles to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",  //ADMIN
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"   //Catherine
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",  //SocialWorker
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb8"   //SocialWorker1
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211", //SocialWorker
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb7"  //SocialWorker2
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212", //Instructor
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb6"  //Instructor1
                },
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212", //Instructor
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb5" //Instructor2
                }
            );
        }



        /// <summary>
        /// Creates all the permissions
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void PermissionsSeeder(ModelBuilder modelBuilder)
        {
            int idCounter = 1;

            //Add permissions to lists
            universalPermissions.Add("CanEditUsers");
            universalPermissions.Add("CanViewApplications");
            universalPermissions.Add("CanEditApplications");
            universalPermissions.Add("CanReviewApplications");

            adminPermissions.Add("CanEditRoles");
            adminPermissions.Add("CanViewSemesters");
            adminPermissions.Add("CanEditSemesters");
            adminPermissions.Add("CanCreateSemesters");

            socialPermissions.Add("CanSocialworkerStuff");

            instructorPermissions.Add("CanInstructorStuff");

            //Add permissions to db. Separated for readability
            //Universal
            for (int i = 0; i < universalPermissions.Count; i++)
            {
                modelBuilder.Entity<Permissions>().HasData(new Permissions
                {
                    PermissionsID = idCounter++, //Just the unique identifier for this permission
                    PermissionsName = universalPermissions[i], //The actual permission
                });
            }
            //Admin
            for (int i = 0; i < adminPermissions.Count; i++)
            {
                modelBuilder.Entity<Permissions>().HasData(new Permissions
                {
                    PermissionsID = idCounter++, //Just the unique identifier for this permission
                    PermissionsName = adminPermissions[i], //The actual permission
                });
            }
            //Social worker
            for (int i = 0; i < socialPermissions.Count; i++)
            {
                modelBuilder.Entity<Permissions>().HasData(new Permissions
                {
                    PermissionsID = idCounter++, //Just the unique identifier for this permission
                    PermissionsName = socialPermissions[i], //The actual permission
                });
            }
            //Instructor
            for (int i = 0; i < instructorPermissions.Count; i++)
            {
                modelBuilder.Entity<Permissions>().HasData(new Permissions
                {
                    PermissionsID = idCounter++, //Just the unique identifier for this permission
                    PermissionsName = instructorPermissions[i], //The actual permission
                });
            }
        }
        /// <summary>
        /// Roles are 'sets' of permissions, while RolePermissions are 'pieces' of that set.
        /// </summary>
        /// <param name="modelBuilder"></param>
        public void RolePermissionsSeeder(ModelBuilder modelBuilder)
        {
            int idCounter = 1;
            #region Universal Permissions seeding
            //Admin
            for (int i = 0; i < universalPermissions.Count; i++)
            {
                modelBuilder.Entity<RolePermission>().HasData(new RolePermission
                {
                    Id = idCounter++, //Unique identifier
                    IdentityRoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210", //ID for the role this set is tied to
                    PermissionsId = i +1 //The permission tied to this piece
                });
            }
            //Social worker
            for (int i = 0; i < universalPermissions.Count; i++)
            {
                modelBuilder.Entity<RolePermission>().HasData(new RolePermission
                {
                    Id = idCounter++,
                    IdentityRoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    PermissionsId = i +1 
                });
            }
            //Instructor
            for (int i = 0; i < universalPermissions.Count; i++)
            {
                modelBuilder.Entity<RolePermission>().HasData(new RolePermission
                {
                    Id = idCounter++,
                    IdentityRoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212", 
                    PermissionsId = i +1
                });
            }
            #endregion

            #region Per-role seeding
            int pId = universalPermissions.Count +1;
            //pId will point to the permissionId for the relevant role, as they were created in the same order they're being added below.
            //Ex, permissionId 5 is the first admin role permission.
            //Admin
            for (int i = 0; i < adminPermissions.Count; i++)
            {
                modelBuilder.Entity<RolePermission>().HasData(new RolePermission
                {
                    Id = idCounter++,
                    IdentityRoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210", 
                    PermissionsId = pId++
                });
            }

            //Social worker
            for (int i = 0; i < socialPermissions.Count; i++)
            {
                modelBuilder.Entity<RolePermission>().HasData(new RolePermission
                {
                    Id = idCounter++,
                    IdentityRoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    PermissionsId = pId++
                });
            }

            //Social worker
            for (int i = 0; i < instructorPermissions.Count; i++)
            {
                modelBuilder.Entity<RolePermission>().HasData(new RolePermission
                {
                    Id = idCounter++,
                    IdentityRoleId = "2c5e174e-3b0e-446f-86af-483d56fd7212",
                    PermissionsId = pId++
                });
            }
            #endregion


        }

    }
}
