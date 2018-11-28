﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppMvcCore.DatabaseContext;

namespace WebAppMvcCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppMvcCore.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode");

                    b.Property<string>("CourseName");

                    b.Property<int?>("DepartmentsId");

                    b.Property<int>("DeptName");

                    b.Property<string>("Time");

                    b.Property<string>("Trainer");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebAppMvcCore.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WebAppMvcCore.Models.Course", b =>
                {
                    b.HasOne("WebAppMvcCore.Models.Department", "Departments")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentsId");
                });
#pragma warning restore 612, 618
        }
    }
}
