﻿// <auto-generated />
using Job_Portal_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Job_Portal_API.Migrations
{
    [DbContext(typeof(Job_Portal_APIContext))]
    [Migration("20200412051836_Job_Portal")]
    partial class Job_Portal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Job_Portal_API.Models.JobPortal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Employer_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryRange")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobPortal");
                });
#pragma warning restore 612, 618
        }
    }
}
