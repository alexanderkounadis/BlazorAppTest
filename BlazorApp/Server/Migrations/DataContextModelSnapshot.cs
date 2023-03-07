﻿// <auto-generated />
using System;
using BlazorApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp.Shared.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4a1b9a46-0a5c-47df-b13f-5d65e3f85e1e"),
                            Address = "Oxford str",
                            City = "London",
                            CompanyName = "Microsoft",
                            ContactName = "Andrew McDonald",
                            Country = "UK",
                            Phone = "123-45678",
                            PostalCode = "12345",
                            Region = "West"
                        },
                        new
                        {
                            Id = new Guid("fde440f7-f329-4802-9e6c-2ba1173fa817"),
                            Address = "Wisconsin str",
                            City = "Madison",
                            CompanyName = "Oracle",
                            ContactName = "Chris Konor",
                            Country = "USA",
                            Phone = "123-45678",
                            PostalCode = "12345",
                            Region = "Milwaukee"
                        },
                        new
                        {
                            Id = new Guid("896b1368-5b4e-4f9f-bd2d-a2c8e13916a0"),
                            Address = "Ag Georgiou 45",
                            City = "Patras",
                            CompanyName = "Epsilon",
                            ContactName = "George Papanikos",
                            Country = "Greece",
                            Phone = "123-45678",
                            PostalCode = "12345",
                            Region = "West"
                        },
                        new
                        {
                            Id = new Guid("1956f1d9-1187-4aed-a840-b95899d5d9fa"),
                            Address = "King str",
                            City = "NY",
                            CompanyName = "Mars",
                            ContactName = "Irene Hunt",
                            Country = "USA",
                            Phone = "123-45678",
                            PostalCode = "12345",
                            Region = "NY"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}