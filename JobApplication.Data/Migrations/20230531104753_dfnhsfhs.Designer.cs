﻿// <auto-generated />
using System;
using JobApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobApplication.Data.Migrations
{
    [DbContext(typeof(JobDbContext))]
    [Migration("20230531104753_dfnhsfhs")]
    partial class dfnhsfhs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobApplication.Data.Models.Domain.OptionMaster", b =>
                {
                    b.Property<int>("OptionMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OptionMasterId"));

                    b.Property<string>("OptionMasterFieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SelectMasterId")
                        .HasColumnType("int");

                    b.HasKey("OptionMasterId");

                    b.HasIndex("SelectMasterId");

                    b.ToTable("OptionMaster");

                    b.HasData(
                        new
                        {
                            OptionMasterId = 32,
                            OptionMasterFieldName = "Gujrati",
                            SelectMasterId = 1
                        },
                        new
                        {
                            OptionMasterId = 33,
                            OptionMasterFieldName = "English",
                            SelectMasterId = 1
                        },
                        new
                        {
                            OptionMasterId = 34,
                            OptionMasterFieldName = "Hindi",
                            SelectMasterId = 1
                        },
                        new
                        {
                            OptionMasterId = 35,
                            OptionMasterFieldName = "Spanish",
                            SelectMasterId = 1
                        },
                        new
                        {
                            OptionMasterId = 36,
                            OptionMasterFieldName = "Mehoni",
                            SelectMasterId = 1
                        },
                        new
                        {
                            OptionMasterId = 37,
                            OptionMasterFieldName = "ASP.Net",
                            SelectMasterId = 2
                        },
                        new
                        {
                            OptionMasterId = 38,
                            OptionMasterFieldName = "Laravell",
                            SelectMasterId = 2
                        },
                        new
                        {
                            OptionMasterId = 39,
                            OptionMasterFieldName = "Django",
                            SelectMasterId = 2
                        },
                        new
                        {
                            OptionMasterId = 40,
                            OptionMasterFieldName = "Express.js",
                            SelectMasterId = 2
                        },
                        new
                        {
                            OptionMasterId = 41,
                            OptionMasterFieldName = "Nest.Js",
                            SelectMasterId = 2
                        },
                        new
                        {
                            OptionMasterId = 42,
                            OptionMasterFieldName = "Flutur",
                            SelectMasterId = 2
                        },
                        new
                        {
                            OptionMasterId = 43,
                            OptionMasterFieldName = "Male",
                            SelectMasterId = 8
                        },
                        new
                        {
                            OptionMasterId = 44,
                            OptionMasterFieldName = "Female",
                            SelectMasterId = 8
                        },
                        new
                        {
                            OptionMasterId = 45,
                            OptionMasterFieldName = "Other",
                            SelectMasterId = 8
                        },
                        new
                        {
                            OptionMasterId = 46,
                            OptionMasterFieldName = "Single",
                            SelectMasterId = 9
                        },
                        new
                        {
                            OptionMasterId = 47,
                            OptionMasterFieldName = "Mingle",
                            SelectMasterId = 9
                        },
                        new
                        {
                            OptionMasterId = 48,
                            OptionMasterFieldName = "Married",
                            SelectMasterId = 9
                        },
                        new
                        {
                            OptionMasterId = 49,
                            OptionMasterFieldName = "Divorced",
                            SelectMasterId = 9
                        },
                        new
                        {
                            OptionMasterId = 50,
                            OptionMasterFieldName = "SSC",
                            SelectMasterId = 10
                        },
                        new
                        {
                            OptionMasterId = 51,
                            OptionMasterFieldName = "HSC",
                            SelectMasterId = 10
                        },
                        new
                        {
                            OptionMasterId = 52,
                            OptionMasterFieldName = "Bacholar",
                            SelectMasterId = 10
                        },
                        new
                        {
                            OptionMasterId = 53,
                            OptionMasterFieldName = "Master",
                            SelectMasterId = 10
                        },
                        new
                        {
                            OptionMasterId = 54,
                            OptionMasterFieldName = "Surat",
                            SelectMasterId = 11
                        },
                        new
                        {
                            OptionMasterId = 55,
                            OptionMasterFieldName = "Ahemdabad",
                            SelectMasterId = 11
                        },
                        new
                        {
                            OptionMasterId = 56,
                            OptionMasterFieldName = "Rajkot",
                            SelectMasterId = 11
                        },
                        new
                        {
                            OptionMasterId = 57,
                            OptionMasterFieldName = "Vadodara",
                            SelectMasterId = 11
                        },
                        new
                        {
                            OptionMasterId = 58,
                            OptionMasterFieldName = "Developement",
                            SelectMasterId = 12
                        },
                        new
                        {
                            OptionMasterId = 59,
                            OptionMasterFieldName = "Networking",
                            SelectMasterId = 12
                        },
                        new
                        {
                            OptionMasterId = 60,
                            OptionMasterFieldName = "HR",
                            SelectMasterId = 12
                        },
                        new
                        {
                            OptionMasterId = 61,
                            OptionMasterFieldName = "Designing",
                            SelectMasterId = 12
                        });
                });

            modelBuilder.Entity("JobApplication.Data.Models.Domain.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsRole")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registration");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Admin@123.com",
                            IsRole = 1,
                            Password = "admin@123",
                            User_Name = "Admin"
                        });
                });

            modelBuilder.Entity("JobApplication.Data.Models.Domain.SelectMaster", b =>
                {
                    b.Property<int>("SelectMasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SelectMasterId"));

                    b.Property<string>("MasterFieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SelectMasterId");

                    b.ToTable("SelectMaster");

                    b.HasData(
                        new
                        {
                            SelectMasterId = 1,
                            MasterFieldName = "Language"
                        },
                        new
                        {
                            SelectMasterId = 2,
                            MasterFieldName = "Technology"
                        },
                        new
                        {
                            SelectMasterId = 8,
                            MasterFieldName = "Gender"
                        },
                        new
                        {
                            SelectMasterId = 9,
                            MasterFieldName = "Relation"
                        },
                        new
                        {
                            SelectMasterId = 10,
                            MasterFieldName = "CourseName"
                        },
                        new
                        {
                            SelectMasterId = 11,
                            MasterFieldName = "PreferedLocation"
                        },
                        new
                        {
                            SelectMasterId = 12,
                            MasterFieldName = "Department"
                        });
                });

            modelBuilder.Entity("JobApplication.Models.Domain.BasicDetailes", b =>
                {
                    b.Property<int>("Basic_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Basic_id"));

                    b.Property<string>("ADDRESS1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ADDRESS2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESIGNATION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIRST_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("LAST_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RELATIONSHIP_STATUS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Basic_id");

                    b.ToTable("BasicDetailes");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EducationId"));

                    b.Property<int>("Basic_id")
                        .HasColumnType("int");

                    b.Property<string>("Board")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassYear")
                        .HasColumnType("int");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.HasKey("EducationId");

                    b.HasIndex("Basic_id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Langauge", b =>
                {
                    b.Property<int>("Langauge_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Langauge_Id"));

                    b.Property<int>("Basic_id")
                        .HasColumnType("int");

                    b.Property<string>("Read")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Write")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("langauge")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Langauge_Id");

                    b.HasIndex("Basic_id");

                    b.ToTable("Langauges");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Prefrences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Basic_id")
                        .HasColumnType("int");

                    b.Property<long>("CurrentCTC")
                        .HasColumnType("bigint");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ExpectedCTC")
                        .HasColumnType("bigint");

                    b.Property<string>("NoticePeriod")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PreferedLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Basic_id");

                    b.ToTable("Prefrences");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Refrence", b =>
                {
                    b.Property<int>("RefrenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefrenceId"));

                    b.Property<int>("Basic_id")
                        .HasColumnType("int");

                    b.Property<long>("ReferencePersonContact")
                        .HasColumnType("bigint");

                    b.Property<string>("ReferencePersonName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RefrencePersonRelation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RefrenceId");

                    b.HasIndex("Basic_id");

                    b.ToTable("Refrences");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Technologies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Basic_id")
                        .HasColumnType("int");

                    b.Property<string>("TechLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TechnologyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Basic_id");

                    b.ToTable("Technologies");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.WorkExperince", b =>
                {
                    b.Property<int>("Work_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Work_Id"));

                    b.Property<int>("Basic_id")
                        .HasColumnType("int");

                    b.Property<string>("Company_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESIGNATION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Work_Id");

                    b.HasIndex("Basic_id");

                    b.ToTable("WorkExperince");
                });

            modelBuilder.Entity("JobApplication.Data.Models.Domain.OptionMaster", b =>
                {
                    b.HasOne("JobApplication.Data.Models.Domain.SelectMaster", "SelectMaster")
                        .WithMany("optionMasters")
                        .HasForeignKey("SelectMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SelectMaster");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Education", b =>
                {
                    b.HasOne("JobApplication.Models.Domain.BasicDetailes", "BasicDetailes")
                        .WithMany("Educations")
                        .HasForeignKey("Basic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicDetailes");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Langauge", b =>
                {
                    b.HasOne("JobApplication.Models.Domain.BasicDetailes", "BasicDetailes")
                        .WithMany("Langauges")
                        .HasForeignKey("Basic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicDetailes");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Prefrences", b =>
                {
                    b.HasOne("JobApplication.Models.Domain.BasicDetailes", "BasicDetailes")
                        .WithMany("Prefrencess")
                        .HasForeignKey("Basic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicDetailes");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Refrence", b =>
                {
                    b.HasOne("JobApplication.Models.Domain.BasicDetailes", "BasicDetailes")
                        .WithMany("Refrences")
                        .HasForeignKey("Basic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicDetailes");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.Technologies", b =>
                {
                    b.HasOne("JobApplication.Models.Domain.BasicDetailes", "BasicDetailes")
                        .WithMany("Technologiess")
                        .HasForeignKey("Basic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicDetailes");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.WorkExperince", b =>
                {
                    b.HasOne("JobApplication.Models.Domain.BasicDetailes", "BasicDetailes")
                        .WithMany("WorkExperinces")
                        .HasForeignKey("Basic_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BasicDetailes");
                });

            modelBuilder.Entity("JobApplication.Data.Models.Domain.SelectMaster", b =>
                {
                    b.Navigation("optionMasters");
                });

            modelBuilder.Entity("JobApplication.Models.Domain.BasicDetailes", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Langauges");

                    b.Navigation("Prefrencess");

                    b.Navigation("Refrences");

                    b.Navigation("Technologiess");

                    b.Navigation("WorkExperinces");
                });
#pragma warning restore 612, 618
        }
    }
}
