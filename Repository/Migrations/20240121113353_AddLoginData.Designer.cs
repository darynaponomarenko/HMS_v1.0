﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.DataAccess;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240121113353_AddLoginData")]
    partial class AddLoginData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repository.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApartmentNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentNr = "40",
                            City = "Warszawa",
                            Country = "Polska",
                            PatientId = 0,
                            State = "mazowieckie",
                            Street = "Wrocławska",
                            Zipcode = "00-014"
                        },
                        new
                        {
                            Id = 2,
                            ApartmentNr = "11",
                            City = "Warszawa",
                            Country = "Polska",
                            PatientId = 0,
                            State = "mazowieckie",
                            Street = "Opolska",
                            Zipcode = "00-006"
                        },
                        new
                        {
                            Id = 3,
                            ApartmentNr = "0/0",
                            City = "Wieleń",
                            Country = "Polska",
                            PatientId = 0,
                            State = "wielkopolskie",
                            Street = "park Orzechowski",
                            Zipcode = "71-912"
                        },
                        new
                        {
                            Id = 4,
                            ApartmentNr = "65b",
                            City = "Sucha Beskidzka",
                            Country = "Polska",
                            PatientId = 0,
                            State = "małopolskie",
                            Street = "al. Szczerba",
                            Zipcode = "33-850"
                        },
                        new
                        {
                            Id = 5,
                            ApartmentNr = "18b",
                            City = "Wyrzysk",
                            Country = "Polska",
                            PatientId = 0,
                            State = "wielkopolskie",
                            Street = "bulw. Łukaszewski",
                            Zipcode = "66-957"
                        },
                        new
                        {
                            Id = 6,
                            ApartmentNr = "795",
                            City = "Krzyż Wielkopolski",
                            Country = "Polska",
                            PatientId = 0,
                            State = "wielkopolskie",
                            Street = "Pająk",
                            Zipcode = "28-489"
                        },
                        new
                        {
                            Id = 7,
                            ApartmentNr = "52b",
                            City = "Józefów",
                            Country = "Polska",
                            PatientId = 0,
                            State = "mazowieckie",
                            Street = "rynek Szczęsny",
                            Zipcode = "58-400"
                        },
                        new
                        {
                            Id = 8,
                            ApartmentNr = "41b",
                            City = "Pyskowice",
                            Country = "Polska",
                            PatientId = 0,
                            State = "śląskie",
                            Street = "os. Drabik",
                            Zipcode = "90-571"
                        });
                });

            modelBuilder.Entity("Repository.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("ICD10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inspection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Interview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Recommendations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReportEntityId")
                        .HasColumnType("int");

                    b.Property<int>("ReportId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("TreatmentContinuationMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentHistory")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientId");

                    b.HasIndex("ReportEntityId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Repository.Models.ContractingAuthorities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContractingAuthorities");
                });

            modelBuilder.Entity("Repository.Models.ICD10", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ICD10s");
                });

            modelBuilder.Entity("Repository.Models.LoginData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkersId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("LoginData");
                });

            modelBuilder.Entity("Repository.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patient");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Patient");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2003, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test@gmail.com",
                            Name = "TestName1",
                            PhoneNumber = "1234567890",
                            Surname = "TestSurname"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1998, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test2@gmail.com",
                            Name = "TestName2",
                            PhoneNumber = "1234567098",
                            Surname = "TestSurname2"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1978, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "test1@gmail.com",
                            Name = "TestName3",
                            PhoneNumber = "123456000",
                            Surname = "TestSurname1"
                        });
                });

            modelBuilder.Entity("Repository.Models.RegisteredAppointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeICD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractingAuthorities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NFZContractNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("PayerExtraNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Payers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procedure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonForAdmission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Worklist")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("RegisteredAppointments");
                });

            modelBuilder.Entity("Repository.Models.ReportEntityModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeICD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractingAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diagnosis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorsData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurposeOfAdvice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentHistory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfForm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfRefferal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Repository.Models.Doctor", b =>
                {
                    b.HasBaseType("Repository.Models.Patient");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("NPWZ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Doctor");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1978, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ksikora@gmail.com",
                            MiddleName = "Antoni",
                            Name = "Klaudiusz",
                            Pesel = "74022667398",
                            PhoneNumber = "+48824167256",
                            Surname = "Sikora",
                            DoctorId = 1,
                            NPWZ = "2481447"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1983, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rnowak@gmail.com",
                            MiddleName = "Arkadiusz",
                            Name = "Robert",
                            Pesel = "63070129769",
                            PhoneNumber = "+48762388491",
                            Surname = "Nowak",
                            DoctorId = 2,
                            NPWZ = "6850524"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1995, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aszymczak@gmail.com",
                            Name = "Asia",
                            Pesel = "86032216879",
                            PhoneNumber = "+48912653345",
                            Surname = "Szymcza",
                            DoctorId = 3,
                            NPWZ = "3774598"
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1981, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hsawicka@gmail.com",
                            MiddleName = "Małgorzata",
                            Name = "Helena",
                            Pesel = "48100316265",
                            PhoneNumber = "+48266939156",
                            Surname = "Sawicka",
                            DoctorId = 4,
                            NPWZ = "8521562"
                        });
                });

            modelBuilder.Entity("Repository.Models.Address", b =>
                {
                    b.HasOne("Repository.Models.Patient", "Patient")
                        .WithMany("Addresses")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Repository.Models.Appointment", b =>
                {
                    b.HasOne("Repository.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.Patient", "Patient")
                        .WithMany("Appointment")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.ReportEntityModel", "ReportEntity")
                        .WithMany()
                        .HasForeignKey("ReportEntityId");

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("ReportEntity");
                });

            modelBuilder.Entity("Repository.Models.LoginData", b =>
                {
                    b.HasOne("Repository.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Repository.Models.RegisteredAppointment", b =>
                {
                    b.HasOne("Repository.Models.Patient", "Patient")
                        .WithMany("RegisteredAppointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Repository.Models.Patient", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Appointment");

                    b.Navigation("RegisteredAppointments");
                });
#pragma warning restore 612, 618
        }
    }
}