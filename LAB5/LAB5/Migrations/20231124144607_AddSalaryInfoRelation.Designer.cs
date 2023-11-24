﻿// <auto-generated />
using System;
using LAB5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LAB5.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20231124144607_AddSalaryInfoRelation")]
    partial class AddSalaryInfoRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LAB5.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Zipcode")
                        .HasMaxLength(5)
                        .HasColumnType("int")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "New York",
                            Country = "USA",
                            Name = "Acme Corporation",
                            Zipcode = 10001
                        },
                        new
                        {
                            Id = 2,
                            City = "San Francisco",
                            Country = "USA",
                            Name = "Tech Solutions Ltd.",
                            Zipcode = 94105
                        },
                        new
                        {
                            Id = 3,
                            City = "Paris",
                            Country = "France",
                            Name = "EuroTech Innovators",
                            Zipcode = 75001
                        },
                        new
                        {
                            Id = 4,
                            City = "Singapore",
                            Country = "Singapore",
                            Name = "Sunrise Global",
                            Zipcode = 4854
                        },
                        new
                        {
                            Id = 5,
                            City = "Melbourne",
                            Country = "Australia",
                            Name = "Down Under Enterprises",
                            Zipcode = 3000
                        });
                });

            modelBuilder.Entity("LAB5.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/Martin.jpg",
                            Name = "Martin",
                            Position = "Marketing Expert",
                            Surname = "Simpson"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/Jacob.jpg",
                            Name = "Jacob",
                            Position = "Manager",
                            Surname = "Hawk"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/Elizabeth.jpg",
                            Name = "Elizabeth",
                            Position = "Software Engineer",
                            Surname = "Geil"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/Kate.jpg",
                            Name = "Kate",
                            Position = "Admin",
                            Surname = "Metain"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/Michael.jpg",
                            Name = "Michael",
                            Position = "Marketing expert",
                            Surname = "Cook"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2001, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/John.jpg",
                            Name = "John",
                            Position = "Software Engineer",
                            Surname = "Snow"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(1999, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/Nina.jpg",
                            Name = "Nina",
                            Position = "Software Engineer",
                            Surname = "Soprano"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(2000, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CompanyId = 0,
                            Image = "/images/Tina.jpg",
                            Name = "Tina",
                            Position = "Team Leader",
                            Surname = "Fins"
                        });
                });

            modelBuilder.Entity("LAB5.Models.SalaryInfo", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Gross")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Net")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.HasIndex(new[] { "EmployeeId" }, "IX_SalaryInfo_EmployeeId")
                        .IsUnique();

                    b.ToTable("SalaryInfo");
                });

            modelBuilder.Entity("LAB5.Models.Employee", b =>
                {
                    b.HasOne("LAB5.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("LAB5.Models.SalaryInfo", b =>
                {
                    b.HasOne("LAB5.Models.Employee", "Employee")
                        .WithOne("SalaryInfo")
                        .HasForeignKey("LAB5.Models.SalaryInfo", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("LAB5.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("LAB5.Models.Employee", b =>
                {
                    b.Navigation("SalaryInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
