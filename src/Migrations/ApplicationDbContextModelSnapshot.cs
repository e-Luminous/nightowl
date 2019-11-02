﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using src.Models;

namespace src.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("src.Models.Account", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AccountLocked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("PhoneConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFaEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("src.Models.Classroom", b =>
                {
                    b.Property<string>("ClassroomId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AccessCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassroomTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeacherSerial")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClassroomId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherSerial");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("src.Models.Course", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("src.Models.CustomUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("src.Models.Experiment", b =>
                {
                    b.Property<string>("ExperimentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExperimentName")
                        .HasColumnType("TEXT");

                    b.HasKey("ExperimentId");

                    b.HasIndex("CourseId");

                    b.ToTable("Experiments");
                });

            modelBuilder.Entity("src.Models.Institution", b =>
                {
                    b.Property<string>("InstitutionId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Established")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstitutionLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstitutionName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Latitude")
                        .HasColumnType("TEXT");

                    b.Property<string>("Longitude")
                        .HasColumnType("TEXT");

                    b.HasKey("InstitutionId");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("src.Models.Student", b =>
                {
                    b.Property<int>("Serial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CollegeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("HscBatch")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstitutionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Shift")
                        .HasColumnType("TEXT");

                    b.HasKey("Serial");

                    b.HasIndex("AccountUserId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("src.Models.StudentEnrollment", b =>
                {
                    b.Property<int>("StudentSerial")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassroomId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EnrollmentDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentSerial", "ClassroomId");

                    b.HasIndex("ClassroomId");

                    b.ToTable("StudentEnrollments");
                });

            modelBuilder.Entity("src.Models.Submission", b =>
                {
                    b.Property<string>("SubmissionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ApiData")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClassroomId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExperimentId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<float>("MarksGiven")
                        .HasColumnType("REAL");

                    b.Property<float>("MarksScale")
                        .HasColumnType("REAL");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentSerial")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TeacherSerial")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubmissionId");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("ExperimentId");

                    b.HasIndex("StudentSerial");

                    b.HasIndex("TeacherSerial");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("src.Models.Teacher", b =>
                {
                    b.Property<int>("Serial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CollegeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseId")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstitutionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Shift")
                        .HasColumnType("TEXT");

                    b.HasKey("Serial");

                    b.HasIndex("AccountUserId");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("src.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("src.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("src.Models.CustomUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("src.Models.Classroom", b =>
                {
                    b.HasOne("src.Models.Course", "Course")
                        .WithMany("Classrooms")
                        .HasForeignKey("CourseId");

                    b.HasOne("src.Models.Teacher", "Teacher")
                        .WithMany("Classrooms")
                        .HasForeignKey("TeacherSerial");
                });

            modelBuilder.Entity("src.Models.Experiment", b =>
                {
                    b.HasOne("src.Models.Course", "Course")
                        .WithMany("Experiments")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("src.Models.Student", b =>
                {
                    b.HasOne("src.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountUserId");

                    b.HasOne("src.Models.Institution", "Institution")
                        .WithMany("Students")
                        .HasForeignKey("InstitutionId");
                });

            modelBuilder.Entity("src.Models.StudentEnrollment", b =>
                {
                    b.HasOne("src.Models.Classroom", "Classroom")
                        .WithMany("StudentEnrollments")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("src.Models.Student", "Student")
                        .WithMany("StudentEnrollments")
                        .HasForeignKey("StudentSerial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("src.Models.Submission", b =>
                {
                    b.HasOne("src.Models.Classroom", "Classroom")
                        .WithMany("Submissions")
                        .HasForeignKey("ClassroomId");

                    b.HasOne("src.Models.Experiment", "Experiment")
                        .WithMany("Submissions")
                        .HasForeignKey("ExperimentId");

                    b.HasOne("src.Models.Student", "Student")
                        .WithMany("Submissions")
                        .HasForeignKey("StudentSerial");

                    b.HasOne("src.Models.Teacher", "Teacher")
                        .WithMany("Submissions")
                        .HasForeignKey("TeacherSerial");
                });

            modelBuilder.Entity("src.Models.Teacher", b =>
                {
                    b.HasOne("src.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountUserId");

                    b.HasOne("src.Models.Course", "Course")
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId");

                    b.HasOne("src.Models.Institution", "Institution")
                        .WithMany("Teachers")
                        .HasForeignKey("InstitutionId");
                });
#pragma warning restore 612, 618
        }
    }
}
