﻿// <auto-generated />
using System;
using BreakevenStoneInfra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BreakevenStoneInfra.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220713124056_corrigeData")]
    partial class corrigeData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BreakevenStoneDomain.Entities.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_Equipment");

                    b.Property<string>("DateIn")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Input_date");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Description_Equipment");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name_Equipment");

                    b.Property<double?>("Price")
                        .HasColumnType("float")
                        .HasColumnName("Price");

                    b.HasKey("Id");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("BreakevenStoneDomain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_Product");

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime")
                        .HasColumnName("Input_Date");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime")
                        .HasColumnName("Output_Date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name_Product");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("Price_Product");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Status_Product");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BreakevenStoneDomain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_User");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(200)")
                        .HasColumnName("Address");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2")
                        .HasColumnName("Birthday");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Password");

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("First_Name");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Last_Name");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BreakevenStoneDomain.Entities.Employee", b =>
                {
                    b.HasBaseType("BreakevenStoneDomain.Entities.User");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id_Employee");

                    b.Property<string>("Fuction")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Function_Employee");

                    b.Property<double>("Salary")
                        .HasColumnType("float")
                        .HasColumnName("Salary");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("BreakevenStoneDomain.Entities.Employee", b =>
                {
                    b.HasOne("BreakevenStoneDomain.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("BreakevenStoneDomain.Entities.Employee", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
