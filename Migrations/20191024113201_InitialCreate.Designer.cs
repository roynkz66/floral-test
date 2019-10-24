﻿// <auto-generated />
using System;
using Floral.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Floral.Migrations
{
    [DbContext(typeof(FloralContext))]
    [Migration("20191024113201_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Floral.Models.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int>("deliverTimeId");

                    b.Property<decimal>("deliveryPrice");

                    b.Property<int>("driverId");

                    b.Property<bool>("isDelivery");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.Property<int>("userDeliveryAddressId");

                    b.HasKey("Id");

                    b.HasIndex("driverId");

                    b.HasIndex("userDeliveryAddressId")
                        .IsUnique();

                    b.ToTable("Delivery");
                });

            modelBuilder.Entity("Floral.Models.DeliveryTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("name");

                    b.Property<decimal>("price");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.ToTable("DeliveryTime");
                });

            modelBuilder.Entity("Floral.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createTime");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<string>("phoneNumber");

                    b.Property<DateTimeOffset>("updateTime");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Floral.Models.FlowerPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PackageTypeId");

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("PackageTypeId");

                    b.ToTable("FlowerPackage");
                });

            modelBuilder.Entity("Floral.Models.FlowerQuantityOrSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PackageId");

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int?>("flowerPackageId");

                    b.Property<bool>("isQuantity");

                    b.Property<bool>("isSize");

                    b.Property<int>("quantity");

                    b.Property<int>("size");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("flowerPackageId");

                    b.ToTable("FlowerQuantityOrSize");
                });

            modelBuilder.Entity("Floral.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<DateTime>("date");

                    b.Property<int>("inventoryStatusId");

                    b.Property<int>("itemId");

                    b.Property<int>("quantity");

                    b.Property<long>("remark");

                    b.Property<int>("stock");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("inventoryStatusId");

                    b.HasIndex("itemId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("Floral.Models.InventoryStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int>("inOrOut");

                    b.Property<string>("statusName");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.ToTable("InventoryStatus");
                });

            modelBuilder.Entity("Floral.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("code");

                    b.Property<decimal>("cost");

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("description");

                    b.Property<decimal>("discount");

                    b.Property<int?>("flowerPackageId");

                    b.Property<string>("image");

                    b.Property<bool>("isPackage");

                    b.Property<bool>("isSellingItem");

                    b.Property<bool>("isStock");

                    b.Property<bool>("isTag");

                    b.Property<string>("name");

                    b.Property<int>("packageId");

                    b.Property<decimal>("sellingPrice");

                    b.Property<int>("stock");

                    b.Property<int>("supplierId");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("flowerPackageId");

                    b.HasIndex("supplierId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Floral.Models.ItemGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("name");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.ToTable("ItemGroup");
                });

            modelBuilder.Entity("Floral.Models.ItemMmItemGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int?>("itemGroupId");

                    b.Property<int?>("itemId");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("itemGroupId");

                    b.HasIndex("itemId");

                    b.ToTable("ItemMmItemGroup");
                });

            modelBuilder.Entity("Floral.Models.ItemTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int>("itemId");

                    b.Property<int>("tagId");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("tagId");

                    b.ToTable("ItemTag");
                });

            modelBuilder.Entity("Floral.Models.MessageCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TagId");

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("message");

                    b.Property<string>("place");

                    b.Property<string>("recipient");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.ToTable("MessageCard");
                });

            modelBuilder.Entity("Floral.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int>("deliveryId");

                    b.Property<int>("messageCardId");

                    b.Property<int>("paymentOptionId");

                    b.Property<decimal>("totalPrice");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.Property<int>("userId");

                    b.HasKey("Id");

                    b.HasIndex("deliveryId");

                    b.HasIndex("messageCardId");

                    b.HasIndex("paymentOptionId");

                    b.HasIndex("userId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Floral.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int>("itemId");

                    b.Property<int>("orderId");

                    b.Property<decimal>("price");

                    b.Property<int>("quantity");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.HasIndex("orderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Floral.Models.PackageItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int>("flowerPackageId");

                    b.Property<int>("itemId");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("flowerPackageId");

                    b.HasIndex("itemId");

                    b.ToTable("PackageItem");
                });

            modelBuilder.Entity("Floral.Models.PackageType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("name");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.ToTable("PackageType");
                });

            modelBuilder.Entity("Floral.Models.PaymentOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("name");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.ToTable("PaymentOption");
                });

            modelBuilder.Entity("Floral.Models.ShoppingCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.Property<int>("userId");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("ShoppingCard");
                });

            modelBuilder.Entity("Floral.Models.ShoppingCardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ShoppingCardId");

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<int>("itemId");

                    b.Property<int>("quantity");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCardId");

                    b.HasIndex("itemId");

                    b.ToTable("ShoppingCardItem");
                });

            modelBuilder.Entity("Floral.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<string>("bank");

                    b.Property<string>("bankAcc");

                    b.Property<string>("campanyName");

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("email");

                    b.Property<string>("phoneNum");

                    b.Property<string>("remark");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.Property<string>("website");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("Floral.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("name");

                    b.Property<int>("tagTypeId");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("tagTypeId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Floral.Models.TagType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("name");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.ToTable("TagType");
                });

            modelBuilder.Entity("Floral.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<string>("phoneNumber");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Floral.Models.UserDeliveryAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.Property<string>("city");

                    b.Property<DateTimeOffset>("createDateTime");

                    b.Property<string>("postcode");

                    b.Property<string>("recipient");

                    b.Property<string>("recipientPhoneNumber");

                    b.Property<string>("state");

                    b.Property<string>("streetAddress");

                    b.Property<DateTimeOffset>("updateDateTime");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserDeliveryAddress");
                });

            modelBuilder.Entity("Floral.Models.Delivery", b =>
                {
                    b.HasOne("Floral.Models.Driver")
                        .WithMany("deliveries")
                        .HasForeignKey("driverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.UserDeliveryAddress")
                        .WithOne("delivery")
                        .HasForeignKey("Floral.Models.Delivery", "userDeliveryAddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.FlowerPackage", b =>
                {
                    b.HasOne("Floral.Models.PackageType", "packageType")
                        .WithMany("flowerPackages")
                        .HasForeignKey("PackageTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.FlowerQuantityOrSize", b =>
                {
                    b.HasOne("Floral.Models.FlowerPackage", "flowerPackage")
                        .WithMany("FlowerQuantityOrSizes")
                        .HasForeignKey("flowerPackageId");
                });

            modelBuilder.Entity("Floral.Models.Inventory", b =>
                {
                    b.HasOne("Floral.Models.InventoryStatus")
                        .WithMany("inventories")
                        .HasForeignKey("inventoryStatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.Item", "Item")
                        .WithMany("Inventories")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.Item", b =>
                {
                    b.HasOne("Floral.Models.FlowerPackage", "flowerPackage")
                        .WithMany()
                        .HasForeignKey("flowerPackageId");

                    b.HasOne("Floral.Models.Supplier", "supplier")
                        .WithMany("Item")
                        .HasForeignKey("supplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.ItemMmItemGroup", b =>
                {
                    b.HasOne("Floral.Models.ItemGroup", "itemGroup")
                        .WithMany("ItemMmItemGroups")
                        .HasForeignKey("itemGroupId");

                    b.HasOne("Floral.Models.Item", "item")
                        .WithMany("ItemMmItemGroups")
                        .HasForeignKey("itemId");
                });

            modelBuilder.Entity("Floral.Models.ItemTag", b =>
                {
                    b.HasOne("Floral.Models.Item", "item")
                        .WithMany("itemTags")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.Tag", "tag")
                        .WithMany("ItemTags")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.MessageCard", b =>
                {
                    b.HasOne("Floral.Models.Tag")
                        .WithMany("MessageCards")
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("Floral.Models.Order", b =>
                {
                    b.HasOne("Floral.Models.Delivery", "delivery")
                        .WithMany()
                        .HasForeignKey("deliveryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.MessageCard", "messageCard")
                        .WithMany()
                        .HasForeignKey("messageCardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.PaymentOption", "paymentOption")
                        .WithMany()
                        .HasForeignKey("paymentOptionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.OrderItem", b =>
                {
                    b.HasOne("Floral.Models.Item", "item")
                        .WithMany("orderItems")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.Order", "order")
                        .WithMany("orderItems")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.PackageItem", b =>
                {
                    b.HasOne("Floral.Models.FlowerPackage", "flowerPackage")
                        .WithMany("PackageItems")
                        .HasForeignKey("flowerPackageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Floral.Models.Item", "item")
                        .WithMany("packageItems")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.ShoppingCard", b =>
                {
                    b.HasOne("Floral.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.ShoppingCardItem", b =>
                {
                    b.HasOne("Floral.Models.ShoppingCard", "ShoppingCard")
                        .WithMany("shoppingCardItems")
                        .HasForeignKey("ShoppingCardId");

                    b.HasOne("Floral.Models.Item", "item")
                        .WithMany("shoppingCardItems")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.Tag", b =>
                {
                    b.HasOne("Floral.Models.TagType", "tagType")
                        .WithMany("tags")
                        .HasForeignKey("tagTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Floral.Models.UserDeliveryAddress", b =>
                {
                    b.HasOne("Floral.Models.User")
                        .WithMany("userDeliveryAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}