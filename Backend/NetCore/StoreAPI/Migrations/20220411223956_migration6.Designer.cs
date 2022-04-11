﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreAPI.Data;

#nullable disable

namespace StoreAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220411223956_migration6")]
    partial class migration6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StoreAPI.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("UserId1");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("StoreAPI.Model.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("StoreAPI.Model.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("StoreAPI.Model.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("StoreAPI.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BillingAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaserId")
                        .HasColumnType("int");

                    b.Property<int>("ShippingAddressId")
                        .HasColumnType("int");

                    b.Property<float>("SubTotal")
                        .HasColumnType("real");

                    b.Property<float>("Tax")
                        .HasColumnType("real");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillingAddressId");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaserId");

                    b.HasIndex("ShippingAddressId");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StoreAPI.Model.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("StoreAPI.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("AvarageScore")
                        .HasColumnType("real");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndsAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemsSold")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StoreAPI.Model.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAnswered")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ProductId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("StoreAPI.Model.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaserId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("StoreAPI.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DefaultBillingAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("DefaultShippingAddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("DefaultBillingAddressId");

                    b.HasIndex("DefaultShippingAddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StoreAPI.Model.Address", b =>
                {
                    b.HasOne("StoreAPI.Model.User", null)
                        .WithMany("BillingAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StoreAPI.Model.User", null)
                        .WithMany("ShippingAddresses")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("StoreAPI.Model.Cart", b =>
                {
                    b.HasOne("StoreAPI.Model.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("StoreAPI.Model.CartItem", b =>
                {
                    b.HasOne("StoreAPI.Model.Cart", null)
                        .WithMany("Items")
                        .HasForeignKey("CartId");

                    b.HasOne("StoreAPI.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreAPI.Model.Image", b =>
                {
                    b.HasOne("StoreAPI.Model.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("StoreAPI.Model.Order", b =>
                {
                    b.HasOne("StoreAPI.Model.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StoreAPI.Model.Product", null)
                        .WithMany("Orders")
                        .HasForeignKey("ProductId");

                    b.HasOne("StoreAPI.Model.User", "Purchaser")
                        .WithMany()
                        .HasForeignKey("PurchaserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreAPI.Model.Address", "ShippingAddress")
                        .WithMany()
                        .HasForeignKey("ShippingAddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StoreAPI.Model.User", null)
                        .WithMany("Orders")
                        .HasForeignKey("UserId1")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BillingAddress");

                    b.Navigation("Purchaser");

                    b.Navigation("ShippingAddress");
                });

            modelBuilder.Entity("StoreAPI.Model.OrderItem", b =>
                {
                    b.HasOne("StoreAPI.Model.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("StoreAPI.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreAPI.Model.Product", b =>
                {
                    b.HasOne("StoreAPI.Model.User", "CreatedBy")
                        .WithMany("MyProducts")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("StoreAPI.Model.Question", b =>
                {
                    b.HasOne("StoreAPI.Model.User", "Author")
                        .WithMany("Questions")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StoreAPI.Model.Product", "Product")
                        .WithMany("Questions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreAPI.Model.Review", b =>
                {
                    b.HasOne("StoreAPI.Model.Order", "Order")
                        .WithOne()
                        .HasForeignKey("StoreAPI.Model.Review", "OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StoreAPI.Model.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("StoreAPI.Model.User", "Purchaser")
                        .WithMany("Reviews")
                        .HasForeignKey("PurchaserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("Purchaser");
                });

            modelBuilder.Entity("StoreAPI.Model.User", b =>
                {
                    b.HasOne("StoreAPI.Model.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("StoreAPI.Model.Address", "DefaultBillingAddress")
                        .WithMany()
                        .HasForeignKey("DefaultBillingAddressId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("StoreAPI.Model.Address", "DefaultShippingAddress")
                        .WithMany()
                        .HasForeignKey("DefaultShippingAddressId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Cart");

                    b.Navigation("DefaultBillingAddress");

                    b.Navigation("DefaultShippingAddress");
                });

            modelBuilder.Entity("StoreAPI.Model.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("StoreAPI.Model.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("StoreAPI.Model.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Orders");

                    b.Navigation("Questions");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("StoreAPI.Model.User", b =>
                {
                    b.Navigation("BillingAddresses");

                    b.Navigation("MyProducts");

                    b.Navigation("Orders");

                    b.Navigation("Questions");

                    b.Navigation("Reviews");

                    b.Navigation("ShippingAddresses");
                });
#pragma warning restore 612, 618
        }
    }
}
