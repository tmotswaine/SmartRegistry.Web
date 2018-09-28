﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRegistry.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180530140250_ChangedTheAudbleBysFromIntToString")]
    partial class ChangedTheAudbleBysFromIntToString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Attendance.Domain.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressType");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Postal")
                        .IsRequired();

                    b.Property<string>("PostalCode")
                        .IsRequired();

                    b.Property<string>("Residential")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Attendance.Domain.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnnouncementType");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<int>("LecturerId");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("LecturerId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("Attendance.Domain.Attended", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<bool>("HasAttended");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<int>("ScheduleId");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendies");
                });

            modelBuilder.Entity("Attendance.Domain.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CellPhone")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("TelePhone")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Attendance.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<int>("DepartmentId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Attendance.Domain.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<int>("FacultyId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Attendance.Domain.EnrolledSubjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<int>("StudentId");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("EnrolledSubjects");
                });

            modelBuilder.Entity("Attendance.Domain.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Attendance.Domain.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountId");

                    b.Property<int>("Age");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DOB");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("Attendance.Domain.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<bool>("IsConfirmed");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<string>("LectureRoom")
                        .IsRequired();

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Attendance.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountId");

                    b.Property<int>("Age");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DOB");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<bool>("IsComplete");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<int>("SensorId");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Attendance.Domain.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastUpdatedAt");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<int>("LecturerId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LecturerId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SmartAttendance.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Attendance.Domain.Announcement", b =>
                {
                    b.HasOne("Attendance.Domain.Lecturer", "Lecturer")
                        .WithMany()
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Attendance.Domain.Attended", b =>
                {
                    b.HasOne("Attendance.Domain.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Attendance.Domain.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Attendance.Domain.Course", b =>
                {
                    b.HasOne("Attendance.Domain.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Attendance.Domain.Department", b =>
                {
                    b.HasOne("Attendance.Domain.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Attendance.Domain.EnrolledSubjects", b =>
                {
                    b.HasOne("Attendance.Domain.Student", "Student")
                        .WithMany("EnrolledSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Attendance.Domain.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Attendance.Domain.Schedule", b =>
                {
                    b.HasOne("Attendance.Domain.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Attendance.Domain.Subject", b =>
                {
                    b.HasOne("Attendance.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Attendance.Domain.Lecturer", "Lecturer")
                        .WithMany()
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SmartAttendance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SmartAttendance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SmartAttendance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SmartAttendance.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
