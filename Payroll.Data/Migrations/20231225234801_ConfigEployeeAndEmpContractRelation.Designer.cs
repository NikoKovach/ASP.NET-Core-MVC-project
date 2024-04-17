﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Payroll.Data;

#nullable disable

namespace Payroll.Data.Migrations
{
    [DbContext(typeof(PayrollContext))]
    [Migration("20231225234801_ConfigEployeeAndEmpContractRelation")]
    partial class ConfigEployeeAndEmpContractRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Payroll.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ApartmentNumber")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Entance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Payroll.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressOfManagement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bullstat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyCaseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepresentativeIdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RepresentedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatOfManagement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Payroll.Models.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("E_MailAddress1")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("E_MailAddress2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActuale")
                        .HasColumnType("bit");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumberOne")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PhoneNumberTwo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("WebSite")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("Payroll.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Payroll.Models.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DiplomaNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EducationId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Profession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("PersonId");

                    b.ToTable("Diplomas");
                });

            modelBuilder.Entity("Payroll.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpContractId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActual")
                        .HasColumnType("bit");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PersonId")
                        .IsUnique()
                        .HasFilter("[PersonId] IS NOT NULL");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Payroll.Models.EmploymentContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("date");

                    b.Property<string>("ContractNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfReceipt")
                        .HasColumnType("date");

                    b.Property<int?>("DeparmentId")
                        .HasColumnType("int");

                    b.Property<string>("EAC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("IsNegotiatedInFavorOf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LaborCodeArticleId")
                        .HasColumnType("int");

                    b.Property<string>("NCOP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("NoticePeriodInDays")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PaidLeaveInDays")
                        .HasColumnType("tinyint");

                    b.Property<double>("PercentSWE")
                        .HasColumnType("float");

                    b.Property<int>("PlaceId")
                        .HasColumnType("int");

                    b.Property<byte>("ProbationInMonths")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte?>("SalaryDayOfTheMonth")
                        .HasColumnType("tinyint");

                    b.Property<string>("SpecialtyWorkExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartingDorkDate")
                        .HasColumnType("date");

                    b.Property<int?>("TrialPeriod")
                        .HasColumnType("int");

                    b.Property<string>("WorkExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("WorkTime")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("ContractTypeId");

                    b.HasIndex("DeparmentId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("LaborCodeArticleId");

                    b.HasIndex("PlaceId");

                    b.ToTable("EmploymentContracts");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.ContractType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContractTypes");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DocumentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.EducationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationTypes");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.LaborCodeArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Article")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LaborCodeArticles");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.PlaceOfRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("PlaceOfRegistrations");
                });

            modelBuilder.Entity("Payroll.Models.IdDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ColorOfEyes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfAcquisitionOfTheCategory")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOgBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOgExpire")
                        .HasColumnType("datetime2");

                    b.Property<long>("DocumentNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("IssuingAuthority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleCategory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("IdDocuments");
                });

            modelBuilder.Entity("Payroll.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CurrentAddressId")
                        .HasColumnType("int");

                    b.Property<string>("EGN")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int?>("PermanentAddressId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrentAddressId");

                    b.HasIndex("GenderId");

                    b.HasIndex("PermanentAddressId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Payroll.Models.ContactInfo", b =>
                {
                    b.HasOne("Payroll.Models.Person", "Person")
                        .WithMany("ContactInfoList")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Payroll.Models.Diploma", b =>
                {
                    b.HasOne("Payroll.Models.EnumTables.EducationType", "EducationType")
                        .WithMany("Diplomas")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Payroll.Models.Person", "Person")
                        .WithMany("Diplomas")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EducationType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Payroll.Models.Employee", b =>
                {
                    b.HasOne("Payroll.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId");

                    b.HasOne("Payroll.Models.Person", "Person")
                        .WithOne("Employee")
                        .HasForeignKey("Payroll.Models.Employee", "PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Company");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Payroll.Models.EmploymentContract", b =>
                {
                    b.HasOne("Payroll.Models.EnumTables.ContractType", "ContractType")
                        .WithMany("EmploymentContracts")
                        .HasForeignKey("ContractTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Payroll.Models.Department", "Department")
                        .WithMany("EmploymentContracts")
                        .HasForeignKey("DeparmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Payroll.Models.Employee", "Employee")
                        .WithOne("EmploymentContract")
                        .HasForeignKey("Payroll.Models.EmploymentContract", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payroll.Models.EnumTables.LaborCodeArticle", "LaborCodeArticle")
                        .WithMany("Contracts")
                        .HasForeignKey("LaborCodeArticleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Payroll.Models.EnumTables.PlaceOfRegistration", "PlaceOfRegistration")
                        .WithMany("EmploymentContracts")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ContractType");

                    b.Navigation("Department");

                    b.Navigation("Employee");

                    b.Navigation("LaborCodeArticle");

                    b.Navigation("PlaceOfRegistration");
                });

            modelBuilder.Entity("Payroll.Models.IdDocument", b =>
                {
                    b.HasOne("Payroll.Models.EnumTables.DocumentType", "DocumentType")
                        .WithMany("IdDocuments")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payroll.Models.Person", "Person")
                        .WithMany("IdDocuments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("DocumentType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Payroll.Models.Person", b =>
                {
                    b.HasOne("Payroll.Models.Address", "CurrentAddress")
                        .WithMany("PersonCurrentAddresesses")
                        .HasForeignKey("CurrentAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Payroll.Models.EnumTables.Gender", "Gender")
                        .WithMany("Persons")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Payroll.Models.Address", "PermanentAddress")
                        .WithMany("PersonPermanentAddresses")
                        .HasForeignKey("PermanentAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CurrentAddress");

                    b.Navigation("Gender");

                    b.Navigation("PermanentAddress");
                });

            modelBuilder.Entity("Payroll.Models.Address", b =>
                {
                    b.Navigation("PersonCurrentAddresesses");

                    b.Navigation("PersonPermanentAddresses");
                });

            modelBuilder.Entity("Payroll.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Payroll.Models.Department", b =>
                {
                    b.Navigation("EmploymentContracts");
                });

            modelBuilder.Entity("Payroll.Models.Employee", b =>
                {
                    b.Navigation("EmploymentContract");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.ContractType", b =>
                {
                    b.Navigation("EmploymentContracts");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.DocumentType", b =>
                {
                    b.Navigation("IdDocuments");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.EducationType", b =>
                {
                    b.Navigation("Diplomas");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.Gender", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.LaborCodeArticle", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.PlaceOfRegistration", b =>
                {
                    b.Navigation("EmploymentContracts");
                });

            modelBuilder.Entity("Payroll.Models.Person", b =>
                {
                    b.Navigation("ContactInfoList");

                    b.Navigation("Diplomas");

                    b.Navigation("Employee");

                    b.Navigation("IdDocuments");
                });
#pragma warning restore 612, 618
        }
    }
}
