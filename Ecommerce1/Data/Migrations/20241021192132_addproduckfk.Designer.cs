﻿// <auto-generated />
using System;
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
    [Migration("20241021192132_addproduckfk")]
    partial class addproduckfk
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
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

                    b.Property<int>("Id_Shop_Session")
                        .HasColumnType("int");

                    b.Property<int>("Id_product")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id_cart");

                    b.HasIndex("Id_Shop_Session");

                    b.HasIndex("Id_product");

                    b.ToTable("CartItems");

                    b.HasData(
                        new
                        {
                            Id_cart = 1,
                            Created = "2023-10-12",
                            Id_Shop_Session = 1,
                            Id_product = 1,
                            Modified = "2023-10-12",
                            Quantity = 2
                        },
                        new
                        {
                            Id_cart = 2,
                            Created = "2023-10-13",
                            Id_Shop_Session = 2,
                            Id_product = 2,
                            Modified = "2023-10-13",
                            Quantity = 3
                        },
                        new
                        {
                            Id_cart = 3,
                            Created = "2023-10-14",
                            Id_Shop_Session = 3,
                            Id_product = 3,
                            Modified = "2023-10-14",
                            Quantity = 1
                        });
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

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Percent")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_discount");

                    b.ToTable("Discounts");

                    b.HasData(
                        new
                        {
                            Id_discount = 1,
                            Created = "2023-10-01 10:30:00",
                            Description = "10% off all fruits",
                            Modified = "2023-10-01 10:30:00",
                            Name = "Fruit Discount",
                            Percent = 10m
                        },
                        new
                        {
                            Id_discount = 2,
                            Created = "2023-10-02 10:30:00",
                            Description = "15% off on dairy products",
                            Modified = "2023-10-02 10:30:00",
                            Name = "Dairy Discount",
                            Percent = 15m
                        },
                        new
                        {
                            Id_discount = 3,
                            Created = "2023-10-03 10:30:00",
                            Description = "Buy 2 Get 1 Free on bakery items",
                            Modified = "2023-10-03 10:30:00",
                            Name = "Bakery Discount",
                            Percent = 5m
                        },
                        new
                        {
                            Id_discount = 4,
                            Created = "2023-10-03 10:30:00",
                            Description = "Buy 3 Get 1 Free on meat products",
                            Modified = "2023-10-03 10:30:00",
                            Name = "Meat Discount",
                            Percent = 10m
                        });
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

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Order");

                    b.HasIndex("Id_product");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id_Order = 1,
                            Created = "2023-10-12",
                            Id_product = 1,
                            Modified = "2023-10-12"
                        },
                        new
                        {
                            Id_Order = 2,
                            Created = "2023-10-13",
                            Id_product = 2,
                            Modified = "2023-10-13"
                        },
                        new
                        {
                            Id_Order = 3,
                            Created = "2023-10-14",
                            Id_product = 3,
                            Modified = "2023-10-14"
                        });
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

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_details");

                    b.HasIndex("Id_Order");

                    b.HasIndex("Id_User");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            Id_details = 1,
                            Created = "2023-10-12",
                            Id_Order = 1,
                            Id_User = 1,
                            Modified = "2023-10-12"
                        },
                        new
                        {
                            Id_details = 2,
                            Created = "2023-10-13",
                            Id_Order = 2,
                            Id_User = 2,
                            Modified = "2023-10-13"
                        },
                        new
                        {
                            Id_details = 3,
                            Created = "2023-10-14",
                            Id_Order = 3,
                            Id_User = 3,
                            Modified = "2023-10-14"
                        });
                });

            modelBuilder.Entity("Ecommerce1.Models.Payment", b =>
                {
                    b.Property<int>("Id_payments")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_payments"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Order")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_payments");

                    b.HasIndex("Id_Order");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id_payments = 1,
                            Amount = 5.00m,
                            Created = "2023-10-12",
                            Id_Order = 1,
                            Modified = "2023-10-12",
                            Provider = "PayPal",
                            Status = "Completed"
                        },
                        new
                        {
                            Id_payments = 2,
                            Amount = 8.50m,
                            Created = "2023-10-13",
                            Id_Order = 2,
                            Modified = "2023-10-13",
                            Provider = "Credit Card",
                            Status = "Pending"
                        },
                        new
                        {
                            Id_payments = 3,
                            Amount = 3.99m,
                            Created = "2023-10-14",
                            Id_Order = 3,
                            Modified = "2023-10-14",
                            Provider = "Bank Transfer",
                            Status = "Completed"
                        });
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

                    b.Property<int?>("Id_discount")
                        .HasColumnType("int");

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_product");

                    b.HasIndex("Id_discount");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id_product = 1,
                            Category = "Fruits",
                            Created = "2023-10-01 10:30:00",
                            Description = "Fresh Red Apple",
                            Id_discount = 1,
                            Modified = "2023-10-05 14:20:00",
                            Name = "Apple",
                            Price = 0.99m,
                            SKU = "FRU-APL-001"
                        },
                        new
                        {
                            Id_product = 2,
                            Category = "Fruits",
                            Created = "2023-10-02 09:15:00",
                            Description = "Exotic Bananas",
                            Id_discount = 1,
                            Modified = "2023-10-06 12:40:00",
                            Name = "Banana",
                            Price = 1.20m,
                            SKU = "FRU-BAN-002"
                        },
                        new
                        {
                            Id_product = 3,
                            Category = "Vegetables",
                            Created = "2023-10-03 11:30:00",
                            Description = "Fresh Carrots",
                            Id_discount = 1,
                            Modified = "2023-10-07 09:00:00",
                            Name = "Carrot",
                            Price = 0.50m,
                            SKU = "VEG-CAR-003"
                        },
                        new
                        {
                            Id_product = 4,
                            Category = "Vegetables",
                            Created = "2023-10-04 14:45:00",
                            Description = "Fresh Lemon",
                            Id_discount = 1,
                            Modified = "2023-10-08 16:20:00",
                            Name = "Lemon",
                            Price = 2.50m,
                            SKU = "VEG-TOM-004"
                        },
                        new
                        {
                            Id_product = 5,
                            Category = "Dairy",
                            Created = "2023-10-05 08:30:00",
                            Description = "Whole Milk, 1 Gallon",
                            Id_discount = 2,
                            Modified = "2023-10-09 15:35:00",
                            Name = "Milk",
                            Price = 3.99m,
                            SKU = "DAR-MIL-005"
                        },
                        new
                        {
                            Id_product = 6,
                            Category = "Dairy",
                            Created = "2023-10-06 12:00:00",
                            Description = "Dozen Organic Eggs",
                            Id_discount = 2,
                            Modified = "2023-10-10 18:00:00",
                            Name = "Eggs",
                            Price = 2.99m,
                            SKU = "DAR-EGG-006"
                        },
                        new
                        {
                            Id_product = 7,
                            Category = "Bakery",
                            Created = "2023-10-07 07:50:00",
                            Description = "Whole Wheat Bread Loaf",
                            Id_discount = 3,
                            Modified = "2023-10-11 12:15:00",
                            Name = "Bread",
                            Price = 2.50m,
                            SKU = "BAK-BRD-007"
                        },
                        new
                        {
                            Id_product = 8,
                            Category = "Meat",
                            Created = "2023-10-08 09:30:00",
                            Description = "Skinless Boneless Chicken Breast, 1 lb",
                            Id_discount = 4,
                            Modified = "2023-10-12 11:45:00",
                            Name = "Chicken Breast",
                            Price = 4.99m,
                            SKU = "MEA-CHK-008"
                        });
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

                    b.Property<string>("Modified")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total_price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Shop_Session");

                    b.HasIndex("Id_user");

                    b.ToTable("ShoppingSessions");

                    b.HasData(
                        new
                        {
                            Id_Shop_Session = 1,
                            Created = "2023-10-12",
                            Id_user = 1,
                            Modified = "2023-10-12",
                            Total_price = 5.00m
                        },
                        new
                        {
                            Id_Shop_Session = 2,
                            Created = "2023-10-13",
                            Id_user = 2,
                            Modified = "2023-10-13",
                            Total_price = 8.50m
                        },
                        new
                        {
                            Id_Shop_Session = 3,
                            Created = "2023-10-14",
                            Id_user = 3,
                            Modified = "2023-10-14",
                            Total_price = 3.99m
                        });
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

                    b.Property<string>("Password")
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

                    b.HasData(
                        new
                        {
                            Id_User = 1,
                            Adress = "1234 Elm St, Springfield",
                            Created = "2023-10-01 10:30:00",
                            Email = "john.doe@gmail.com",
                            Name = "John",
                            Password = "gM}56fjg",
                            Phone_number = "+1 555-123-4567",
                            Surname = "Doe",
                            modified = "2023-10-10 12:45:00"
                        },
                        new
                        {
                            Id_User = 2,
                            Adress = "5678 Oak St, Greenfield",
                            Created = "2023-10-02 11:20:00",
                            Email = "jane.smith@protonmail.com",
                            Name = "Jane",
                            Password = ">3LUmc=RvyGRHW%g/-~z",
                            Phone_number = "+1 555-987-6543",
                            Surname = "Smith",
                            modified = "2023-10-11 15:00:00"
                        },
                        new
                        {
                            Id_User = 3,
                            Adress = "9101 Pine St, Brookfield",
                            Created = "2023-10-03 14:45:00",
                            Email = "mark.williams@domain.com",
                            Name = "Mark",
                            Password = "x*D5-UV/89`&^_q,v-H7",
                            Phone_number = "+1 555-321-7654",
                            Surname = "Williams",
                            modified = "2023-10-12 09:10:00"
                        },
                        new
                        {
                            Id_User = 4,
                            Adress = "2468 Maple St, Hilltown",
                            Created = "2023-10-04 09:50:00",
                            Email = "emma.jones@outlook.com",
                            Name = "Emma",
                            Password = "fCxwnchJs1w|-S}YA>-F",
                            Phone_number = "+1 555-654-3210",
                            Surname = "Jones",
                            modified = "2023-10-11 16:30:00"
                        },
                        new
                        {
                            Id_User = 5,
                            Adress = "1357 Birch St, Riverview",
                            Created = "2023-10-05 08:30:00",
                            Email = "robert.brown@yahoo.com",
                            Name = "Robert",
                            Password = "(y.<vQ3[8w*]KYgMs3ab",
                            Phone_number = "+1 555-555-7890",
                            Surname = "Brown",
                            modified = "2023-10-12 14:20:00"
                        });
                });

            modelBuilder.Entity("Ecommerce1.Models.Cart_item", b =>
                {
                    b.HasOne("Ecommerce1.Models.Shopping_Session", "Shopping_Session")
                        .WithMany()
                        .HasForeignKey("Id_Shop_Session")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce1.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("Id_product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Shopping_Session");
                });

            modelBuilder.Entity("Ecommerce1.Models.Order", b =>
                {
                    b.HasOne("Ecommerce1.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("Id_product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce1.Models.Order_Details", b =>
                {
                    b.HasOne("Ecommerce1.Models.Order", "Orders")
                        .WithMany("Order_Details")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce1.Models.User", "Users")
                        .WithMany("Order_Detail")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Ecommerce1.Models.Payment", b =>
                {
                    b.HasOne("Ecommerce1.Models.Order", "Orders")
                        .WithMany("Payment")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce1.Models.Product", b =>
                {
                    b.HasOne("Ecommerce1.Models.Discount", "Discount")
                        .WithMany("Product")
                        .HasForeignKey("Id_discount");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("Ecommerce1.Models.Shopping_Session", b =>
                {
                    b.HasOne("Ecommerce1.Models.User", "Users")
                        .WithMany("Shopping_Sessions")
                        .HasForeignKey("Id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Ecommerce1.Models.Discount", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ecommerce1.Models.Order", b =>
                {
                    b.Navigation("Order_Details");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Ecommerce1.Models.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Ecommerce1.Models.User", b =>
                {
                    b.Navigation("Order_Detail");

                    b.Navigation("Shopping_Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
