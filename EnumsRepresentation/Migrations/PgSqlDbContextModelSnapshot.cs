﻿// <auto-generated />
using System;
using EnumsRepresentation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EnumsRepresentation.Migrations
{
    [DbContext(typeof(PgSqlDbContext))]
    partial class PgSqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EnumsRepresentation.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CarTypeId")
                        .HasColumnType("integer");

                    b.Property<float>("Size")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("EnumsRepresentation.CarTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CarTypeEntity");

                    b.HasData(
                        new
                        {
                            Id = 0,
                            Description = "описание для типа можно взять из аттрибута OpenCar",
                            Name = "OpenCar"
                        },
                        new
                        {
                            Id = 1,
                            Description = "описание для типа можно взять из аттрибута InnovativeCar",
                            Name = "InnovativeCar"
                        },
                        new
                        {
                            Id = 2,
                            Description = "описание для типа можно взять из аттрибута Tank",
                            Name = "Tank"
                        },
                        new
                        {
                            Id = 3,
                            Description = "описание для типа можно взять из аттрибута NewAdded",
                            Name = "NewAdded"
                        });
                });

            modelBuilder.Entity("EnumsRepresentation.Car", b =>
                {
                    b.HasOne("EnumsRepresentation.CarTypeEntity", null)
                        .WithMany()
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
