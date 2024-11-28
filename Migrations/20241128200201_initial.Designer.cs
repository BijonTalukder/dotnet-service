﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dotnet_service.data;

#nullable disable

namespace dotnet_service.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241128200201_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("dotnet_service.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("DeliveryFee")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("EstimatedDeliveryTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PlacedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
