using JobApplication.Data.Models.Domain;
using JobApplication.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace JobApplication.Data
{
    public class JobDbContext :DbContext
    {
        public JobDbContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Data For Admin
            modelBuilder.Entity<Registration>().HasData(
                new Registration
                {
                    Id = 1,
                    User_Name = "Admin",
                    Email = "Admin@123.com",
                    Password = "admin@123",
                    IsRole = 1
                });
            #endregion

            modelBuilder.Entity<SelectMaster>()
                .HasData(
                   new SelectMaster
                   {
                       SelectMasterId = 1,
                       MasterFieldName = "Language",

                   },
                    new SelectMaster
                    {
                        SelectMasterId = 2,
                        MasterFieldName = "Technology",

                    },
                     new SelectMaster
                     {
                         SelectMasterId = 8,
                         MasterFieldName = "Gender",

                     },
                     new SelectMaster
                     {
                         SelectMasterId = 9,
                         MasterFieldName = "Relation",
                     },
                     new SelectMaster
                     {
                         SelectMasterId = 10,
                         MasterFieldName = "CourseName",
                     },
                     new SelectMaster
                     {
                         SelectMasterId = 11,
                         MasterFieldName = "PreferedLocation",
                     },
                     new SelectMaster
                     {
                         SelectMasterId = 12,
                         MasterFieldName = "Department",
                     }
                   );
            modelBuilder.Entity<OptionMaster>()
                 .HasData(
                          //Language
                          new OptionMaster
                          {
                              OptionMasterId = 32,
                              OptionMasterFieldName = "Gujrati",
                              SelectMasterId = 1
                          },
                          new OptionMaster
                          {
                              OptionMasterId = 33,
                              OptionMasterFieldName = "English",
                              SelectMasterId = 1

                          },
                          new OptionMaster
                          {
                              OptionMasterId = 34,
                              OptionMasterFieldName = "Hindi",
                              SelectMasterId = 1
                          },
                             new OptionMaster
                             {
                                 OptionMasterId = 35,
                                 OptionMasterFieldName = "Spanish",
                                 SelectMasterId = 1
                             },
                             new OptionMaster
                             {
                                 OptionMasterId = 36,
                                 OptionMasterFieldName = "Mehoni",
                                 SelectMasterId = 1

                             },
                   //Technology
                   new OptionMaster
                   {
                       OptionMasterId = 37,
                       SelectMasterId = 2,
                       OptionMasterFieldName = "ASP.Net",

                   },
                   new OptionMaster
                   {
                       OptionMasterId = 38,
                       SelectMasterId = 2,
                       OptionMasterFieldName = "Laravell",
                   },
                   new OptionMaster
                   {
                       OptionMasterId = 39,
                       OptionMasterFieldName = "Django",
                       SelectMasterId = 2,
                   },
                   new OptionMaster
                   {
                       OptionMasterId = 40,
                       OptionMasterFieldName = "Express.js",
                       SelectMasterId = 2,
                   },
                   new OptionMaster
                   {
                       OptionMasterId = 41,
                       SelectMasterId = 2,
                       OptionMasterFieldName = "Nest.Js",

                   }, new OptionMaster
                   {
                       OptionMasterId = 42,
                       SelectMasterId = 2,
                       OptionMasterFieldName = "Flutur",
                   },

                   //Gender
                   new OptionMaster
                   {
                       OptionMasterId = 43,
                       SelectMasterId = 8,
                       OptionMasterFieldName = "Male",
                   },
                   new OptionMaster
                   {
                       OptionMasterId = 44,
                       OptionMasterFieldName = "Female",
                       SelectMasterId = 8,
                   },
                   new OptionMaster
                   {
                       OptionMasterId = 45,
                       OptionMasterFieldName = "Other",
                       SelectMasterId = 8,
                   },

                   //Relation
                   new OptionMaster
                   {
                       OptionMasterId = 46,
                       SelectMasterId = 9,
                       OptionMasterFieldName = "Single",
                   },
                    new OptionMaster
                    {
                        OptionMasterId = 47,
                        SelectMasterId = 9,
                        OptionMasterFieldName = "Mingle",
                    },
                     new OptionMaster
                     {
                         OptionMasterId = 48,
                         SelectMasterId = 9,
                         OptionMasterFieldName = "Married",
                     },
                      new OptionMaster
                      {
                          OptionMasterId = 49,
                          SelectMasterId = 9,
                          OptionMasterFieldName = "Divorced",
                      },
                       // Course Name
                       new OptionMaster
                       {
                           OptionMasterId = 50,
                           SelectMasterId = 10,
                           OptionMasterFieldName = "SSC",
                       },
                       new OptionMaster
                       {
                           OptionMasterId = 51,
                           SelectMasterId = 10,
                           OptionMasterFieldName = "HSC",
                       },
                       new OptionMaster
                       {
                           OptionMasterId = 52,
                           SelectMasterId = 10,
                           OptionMasterFieldName = "Bacholar",
                       },
                       new OptionMaster
                       {
                           OptionMasterId = 53,
                           SelectMasterId = 10,
                           OptionMasterFieldName = "Master",
                       },
                       // Preffred Location
                       new OptionMaster
                       {
                           OptionMasterId = 54,
                           SelectMasterId = 11,
                           OptionMasterFieldName = "Surat",
                       },
                        new OptionMaster
                        {
                            OptionMasterId = 55,
                            SelectMasterId = 11,
                            OptionMasterFieldName = "Ahemdabad",
                        },
                         new OptionMaster
                         {
                             OptionMasterId = 56,
                             SelectMasterId = 11,
                             OptionMasterFieldName = "Rajkot",
                         },
                          new OptionMaster
                          {
                              OptionMasterId = 57,
                              SelectMasterId = 11,
                              OptionMasterFieldName = "Vadodara",
                          },

                       // Department
                       new OptionMaster
                       {
                           OptionMasterId = 58,
                           SelectMasterId = 12,
                           OptionMasterFieldName = "Developement",
                       },
                        new OptionMaster
                        {
                            OptionMasterId = 59,
                            SelectMasterId = 12,
                            OptionMasterFieldName = "Networking",
                        },
                         new OptionMaster
                         {
                             OptionMasterId = 60,
                             SelectMasterId = 12,
                             OptionMasterFieldName = "HR",
                         },
                          new OptionMaster
                          {
                              OptionMasterId = 61,
                              SelectMasterId = 12,
                              OptionMasterFieldName = "Designing",
                          }




            );
        }
        #region registration 
        public DbSet<Registration> Registration { get; set; }
        #endregion
        public DbSet<Education> Educations { get; set; }
        public DbSet<Langauge> Langauges { get; set; }  
        public DbSet<Refrence> Refrences { get; set; }  
        public DbSet<Prefrences> Prefrences { get; set; }
        public DbSet<BasicDetailes> BasicDetailes { get; set;}
        public DbSet<Technologies> Technologies { get; set; }

        public DbSet<WorkExperince> WorkExperince { get; set;}
        public DbSet<SelectMaster> SelectMaster { get; set; }   
        public DbSet<OptionMaster> OptionMaster { get; set; }
    }
}
