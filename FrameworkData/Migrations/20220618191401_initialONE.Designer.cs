﻿// <auto-generated />
using System;
using FrameworkData.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FrameworkData.Migrations
{
    [DbContext(typeof(DataConection))]
    [Migration("20220618191401_initialONE")]
    partial class initialONE
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorModelPatientModel", b =>
                {
                    b.Property<int>("doctorsId")
                        .HasColumnType("int");

                    b.Property<int>("patientsId")
                        .HasColumnType("int");

                    b.HasKey("doctorsId", "patientsId");

                    b.HasIndex("patientsId");

                    b.ToTable("DoctorModelPatientModel");
                });

            modelBuilder.Entity("FrameworkData.Model.DepartmentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("FrameworkData.Model.DoctorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentModelId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentModelId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("FrameworkData.Model.PatientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentModelId")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentModelId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DoctorModelPatientModel", b =>
                {
                    b.HasOne("FrameworkData.Model.DoctorModel", null)
                        .WithMany()
                        .HasForeignKey("doctorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FrameworkData.Model.PatientModel", null)
                        .WithMany()
                        .HasForeignKey("patientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FrameworkData.Model.DoctorModel", b =>
                {
                    b.HasOne("FrameworkData.Model.DepartmentModel", null)
                        .WithMany("doctors")
                        .HasForeignKey("DepartmentModelId");
                });

            modelBuilder.Entity("FrameworkData.Model.PatientModel", b =>
                {
                    b.HasOne("FrameworkData.Model.DepartmentModel", null)
                        .WithMany("patients")
                        .HasForeignKey("DepartmentModelId");
                });

            modelBuilder.Entity("FrameworkData.Model.DepartmentModel", b =>
                {
                    b.Navigation("doctors");

                    b.Navigation("patients");
                });
#pragma warning restore 612, 618
        }
    }
}