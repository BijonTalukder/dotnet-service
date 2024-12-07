﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dotnet_service.data;

#nullable disable

namespace dotnet_service.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PlacedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("StoreId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalPaid")
                        .HasColumnType("numeric");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("dotnet_service.Models.OrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<Guid?>("OrderId1")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("SelectedOptions")
                        .HasColumnType("text");

                    b.Property<string>("SpecialInstructions")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrderId1");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("dotnet_service.Models.OrderItems", b =>
                {
                    b.HasOne("dotnet_service.Models.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId1");
                });

            modelBuilder.Entity("dotnet_service.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
