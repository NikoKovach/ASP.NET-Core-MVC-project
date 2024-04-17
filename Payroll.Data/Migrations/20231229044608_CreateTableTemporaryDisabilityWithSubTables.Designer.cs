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
    [Migration("20231229044608_CreateTableTemporaryDisabilityWithSubTables")]
    partial class CreateTableTemporaryDisabilityWithSubTables
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

            modelBuilder.Entity("Payroll.Models.Annex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte?>("AdditionalPaidAnnualLeaveInDays")
                        .HasColumnType("tinyint");

                    b.Property<string>("AgreementNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CountedFromDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateOfAgreementOrChange")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateOfReceipt")
                        .HasColumnType("date");

                    b.Property<byte?>("DayWorkTime")
                        .HasColumnType("tinyint");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("EAC")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("EmpContractId")
                        .HasColumnType("int");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("LaborCodeArticleId")
                        .HasColumnType("int");

                    b.Property<string>("NCOP")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<byte?>("NoticePeriodInDays")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("PaidAnnualLeaveInDays")
                        .HasColumnType("tinyint");

                    b.Property<double?>("PercentSWE")
                        .HasColumnType("float");

                    b.Property<bool?>("ReceivedAJobDescription")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte?>("SalaryDayOfTheMonth")
                        .HasColumnType("tinyint");

                    b.Property<int?>("WorkPlaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmpContractId");

                    b.ToTable("Annexes");
                });

            modelBuilder.Entity("Payroll.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressOfManagement")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Bullstat")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CompanyCaseNumber")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RepresentativeIdNumber")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("RepresentedBy")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeatOfManagement")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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

                    b.Property<byte>("AdditionalPaidAnnualLeaveInDays")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ContractDate")
                        .HasColumnType("date");

                    b.Property<string>("ContractNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ContractTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfReceipt")
                        .HasColumnType("date");

                    b.Property<int?>("DeparmentId")
                        .HasColumnType("int");

                    b.Property<string>("EAC")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("IsNegotiatedInFavorOf")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("LaborCodeArticleId")
                        .HasColumnType("int");

                    b.Property<string>("NCOP")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<byte>("NoticePeriodInDays")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PaidLeaveInDays")
                        .HasColumnType("tinyint")
                        .HasColumnName("PaidAnnualLeaveInDays");

                    b.Property<double>("PercentSWE")
                        .HasColumnType("float");

                    b.Property<int?>("PlaceId")
                        .HasColumnType("int");

                    b.Property<byte>("ProbationInMonths")
                        .HasColumnType("tinyint");

                    b.Property<bool>("ReceivedAJobDescription")
                        .HasColumnType("bit");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte?>("SalaryDayOfTheMonth")
                        .HasColumnType("tinyint");

                    b.Property<string>("SpecialtyWorkExperience")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("StartingWorkDate")
                        .HasColumnType("date");

                    b.Property<int?>("TrialPeriod")
                        .HasColumnType("int");

                    b.Property<string>("WorkExperience")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("WorkPlaceId")
                        .HasColumnType("int");

                    b.Property<byte>("WorkTime")
                        .HasColumnType("tinyint")
                        .HasColumnName("DayWorkTime");

                    b.HasKey("Id");

                    b.HasIndex("ContractTypeId");

                    b.HasIndex("DeparmentId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("LaborCodeArticleId");

                    b.HasIndex("PlaceId");

                    b.HasIndex("WorkPlaceId");

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

            modelBuilder.Entity("Payroll.Models.EnumTables.ModeOfTreatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ModeName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("TemporaryDisabilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TemporaryDisabilityId");

                    b.ToTable("ModeOfTreatments");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.PlaceOfRegistration", b =>
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

                    b.Property<string>("Entance")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("PlaceOfRegistrationOrWork");
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

                    b.Property<int?>("DocumentTypeId")
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

            modelBuilder.Entity("Payroll.Models.TemporaryDisability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressOfThePublisher")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("AllLeaveOnCalendarDays")
                        .HasColumnType("int");

                    b.Property<string>("AmbulatorySheetNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DateToNextExamination")
                        .HasColumnType("date");

                    b.Property<string>("DaysInAWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diagnosis")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DiagnosisAccordingToICD")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("GenderId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("IssuedBy")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("OnLeaveFrom")
                        .HasColumnType("date");

                    b.Property<DateTime>("OnLeaveUntil")
                        .HasColumnType("date");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Reason")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RegNumberMedFacility")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SickSheetNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("TypeSickSheetId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("GenderId");

                    b.HasIndex("TypeSickSheetId");

                    b.ToTable("TemporaryDisabilities");
                });

            modelBuilder.Entity("Payroll.Models.TypeSickSheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TypeSickSheets");
                });

            modelBuilder.Entity("Payroll.Models.Annex", b =>
                {
                    b.HasOne("Payroll.Models.Department", "Department")
                        .WithMany("Annexes")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Payroll.Models.EmploymentContract", "EmpContract")
                        .WithMany("SupplementaryAgreements")
                        .HasForeignKey("EmpContractId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Department");

                    b.Navigation("EmpContract");
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
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.SetNull);

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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Payroll.Models.EnumTables.LaborCodeArticle", "LaborCodeArticle")
                        .WithMany("Contracts")
                        .HasForeignKey("LaborCodeArticleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Payroll.Models.EnumTables.PlaceOfRegistration", "PlaceOfRegistration")
                        .WithMany("EmploymentContracts")
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Payroll.Models.EnumTables.PlaceOfRegistration", "WorkPlace")
                        .WithMany("WorkPlaceEmploymentContracts")
                        .HasForeignKey("WorkPlaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ContractType");

                    b.Navigation("Department");

                    b.Navigation("Employee");

                    b.Navigation("LaborCodeArticle");

                    b.Navigation("PlaceOfRegistration");

                    b.Navigation("WorkPlace");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.ModeOfTreatment", b =>
                {
                    b.HasOne("Payroll.Models.TemporaryDisability", "TemporaryDisability")
                        .WithMany("ModeOfTreatments")
                        .HasForeignKey("TemporaryDisabilityId");

                    b.Navigation("TemporaryDisability");
                });

            modelBuilder.Entity("Payroll.Models.IdDocument", b =>
                {
                    b.HasOne("Payroll.Models.EnumTables.DocumentType", "DocumentType")
                        .WithMany("IdDocuments")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.SetNull);

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

            modelBuilder.Entity("Payroll.Models.TemporaryDisability", b =>
                {
                    b.HasOne("Payroll.Models.Employee", "Employee")
                        .WithMany("TemporaryDisabilities")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payroll.Models.EnumTables.Gender", "Gender")
                        .WithMany("TemporaryDisabilities")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Payroll.Models.TypeSickSheet", "TypeSickSheet")
                        .WithMany("TemporaryDisabilities")
                        .HasForeignKey("TypeSickSheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Gender");

                    b.Navigation("TypeSickSheet");
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
                    b.Navigation("Annexes");

                    b.Navigation("EmploymentContracts");
                });

            modelBuilder.Entity("Payroll.Models.Employee", b =>
                {
                    b.Navigation("EmploymentContract");

                    b.Navigation("TemporaryDisabilities");
                });

            modelBuilder.Entity("Payroll.Models.EmploymentContract", b =>
                {
                    b.Navigation("SupplementaryAgreements");
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

                    b.Navigation("TemporaryDisabilities");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.LaborCodeArticle", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("Payroll.Models.EnumTables.PlaceOfRegistration", b =>
                {
                    b.Navigation("EmploymentContracts");

                    b.Navigation("WorkPlaceEmploymentContracts");
                });

            modelBuilder.Entity("Payroll.Models.Person", b =>
                {
                    b.Navigation("ContactInfoList");

                    b.Navigation("Diplomas");

                    b.Navigation("Employee");

                    b.Navigation("IdDocuments");
                });

            modelBuilder.Entity("Payroll.Models.TemporaryDisability", b =>
                {
                    b.Navigation("ModeOfTreatments");
                });

            modelBuilder.Entity("Payroll.Models.TypeSickSheet", b =>
                {
                    b.Navigation("TemporaryDisabilities");
                });
#pragma warning restore 612, 618
        }
    }
}
