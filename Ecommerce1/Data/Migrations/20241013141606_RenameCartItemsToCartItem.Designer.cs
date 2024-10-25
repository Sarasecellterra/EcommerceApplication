﻿// <auto-generated />
using Ecommerce1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241013141606_RenameCartItemsToCartItem")]
    partial class RenameCartItemsToCartItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce1.Models.Cart_item", b =>
                {
                    b.Property<int>("Id_cart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_cart"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<string>("Total_Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_cart");

                    b.ToTable("Cart_item");
                });

            modelBuilder.Entity("Ecommerce1.Models.Discount", b =>
                {
                    b.Property<int>("Id_discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_discount"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Percent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_discount");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Ecommerce1.Models.Order", b =>
                {
                    b.Property<int>("Id_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Order"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Order");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Ecommerce1.Models.Order_Details", b =>
                {
                    b.Property<int>("Id_details")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_details"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<int>("Id_User")
                        .HasColumnType("int");

                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_details");

                    b.ToTable("Order_Detail");
                });

            modelBuilder.Entity("Ecommerce1.Models.Payment", b =>
                {
                    b.Property<int>("Id_payments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_payments"));

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_payments");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Ecommerce1.Models.Product", b =>
                {
                    b.Property<int>("Id_product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_product"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_product");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ecommerce1.Models.Shopping_Session", b =>
                {
                    b.Property<int>("Id_Shop_Session")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Shop_Session"));

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<string>("Total_price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Shop_Session");

                    b.ToTable("Shopping_Sessions");
                });

            modelBuilder.Entity("Ecommerce1.Models.User", b =>
                {
                    b.Property<int>("Id_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_User"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_User");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
