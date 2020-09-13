﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(EmployeeDetailContext))]
    partial class EmployeeDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.EmployeeDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("DOJ")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SkillSets")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ID");

                    b.ToTable("EmployeeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
