﻿// <auto-generated />
using System;
using AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppData.Migrations
{
    [DbContext(typeof(HrContext))]
    [Migration("20200621120501_Add initial entity models")]
    partial class Addinitialentitymodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppData.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumarContract")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("TipContract")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("AppData.Models.ContractFiscality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fiscalitate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SeAcordaDeduceri")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractFiscalities");
                });

            modelBuilder.Entity("AppData.Models.ContractInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Asigurare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanieAsigurare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractInsurances");
                });

            modelBuilder.Entity("AppData.Models.ContractOrganizatoricalAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Departament")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Functie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractOrganizatoricalAssignments");
                });

            modelBuilder.Entity("AppData.Models.ContractPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Perioada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractPeriods");
                });

            modelBuilder.Entity("AppData.Models.ContractSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.Property<double>("Salariu")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractSalaries");
                });

            modelBuilder.Entity("AppData.Models.ContractWorkProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.Property<string>("Norma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramLucru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractWorkPrograms");
                });

            modelBuilder.Entity("AppData.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNastere")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Marca")
                        .HasColumnType("int");

                    b.Property<string>("Nationalitate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("AppData.Models.PersonAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Apartament")
                        .HasColumnType("int");

                    b.Property<string>("Bloc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataInceput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSfarsit")
                        .HasColumnType("datetime2");

                    b.Property<int>("Etaj")
                        .HasColumnType("int");

                    b.Property<string>("Judet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localitate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.Property<int>("PersoanaId")
                        .HasColumnType("int");

                    b.Property<string>("Strada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersoanaId");

                    b.ToTable("PersonAddresses");
                });

            modelBuilder.Entity("AppData.Models.PersonIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CNP")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEmitere")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExpirare")
                        .HasColumnType("datetime2");

                    b.Property<int>("Emitent")
                        .HasColumnType("int");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.Property<int>("PersoanaId")
                        .HasColumnType("int");

                    b.Property<int>("Serie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersoanaId");

                    b.ToTable("PersonIdentities");
                });

            modelBuilder.Entity("AppData.Models.Contract", b =>
                {
                    b.HasOne("AppData.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.ContractFiscality", b =>
                {
                    b.HasOne("AppData.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.ContractInsurance", b =>
                {
                    b.HasOne("AppData.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.ContractOrganizatoricalAssignment", b =>
                {
                    b.HasOne("AppData.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.ContractPeriod", b =>
                {
                    b.HasOne("AppData.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.ContractSalary", b =>
                {
                    b.HasOne("AppData.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.ContractWorkProgram", b =>
                {
                    b.HasOne("AppData.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.PersonAddress", b =>
                {
                    b.HasOne("AppData.Models.Person", "Persoana")
                        .WithMany()
                        .HasForeignKey("PersoanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppData.Models.PersonIdentity", b =>
                {
                    b.HasOne("AppData.Models.Person", "Persoana")
                        .WithMany()
                        .HasForeignKey("PersoanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
