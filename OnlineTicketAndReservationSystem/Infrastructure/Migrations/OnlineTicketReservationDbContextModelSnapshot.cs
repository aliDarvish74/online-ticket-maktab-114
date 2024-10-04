﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(OnlineTicketReservationDbContext))]
    partial class OnlineTicketReservationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("VarChar");

                    b.Property<DateTime>("UpdatedDataTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Model.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("ProvinceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDataTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("ProvinceId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d2cbd482-a755-499c-981b-8601f7f3b9dc"),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(925),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Name = "تهران",
                            ProvinceId = new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(936),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        },
                        new
                        {
                            Id = new Guid("91cd48a1-7da4-4beb-af28-d715a175598a"),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(958),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Name = "کرج",
                            ProvinceId = new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(959),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        },
                        new
                        {
                            Id = new Guid("bd3ee152-3818-4831-9859-74d7068e0d05"),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(965),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Name = "دماوند",
                            ProvinceId = new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(966),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        },
                        new
                        {
                            Id = new Guid("0351c650-5ee4-4258-9500-537ede428e60"),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(974),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Name = "سعادتشهر",
                            ProvinceId = new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(975),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        },
                        new
                        {
                            Id = new Guid("73b05b9b-2748-4d9d-85e6-41915cf5d29f"),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(982),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Name = "پرند",
                            ProvinceId = new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(983),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        });
                });

            modelBuilder.Entity("Model.Entities.Province", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDataTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            Id = new Guid("84c3d84b-b54f-4e03-8fc6-5130cd643c47"),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(3316),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Name = "تهران",
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 72, DateTimeKind.Local).AddTicks(3321),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        });
                });

            modelBuilder.Entity("Model.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleDescription")
                        .HasMaxLength(500)
                        .HasColumnType("NVarChar");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VarChar");

                    b.Property<string>("RolePersianName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVarChar");

                    b.Property<DateTime>("UpdatedDataTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedUserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Model.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BuyDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(6742));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("TicketNumber")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("VarChar");

                    b.Property<DateTime>("UpdatedDataTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedUserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6282afc8-f82f-4d6f-9e4e-e22374cedee9"),
                            BuyDate = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7869),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7879),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            SeatNumber = 0,
                            TicketNumber = "11727",
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7881),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            UserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        },
                        new
                        {
                            Id = new Guid("86a9d4a5-3239-49dd-89c0-b2555a582b51"),
                            BuyDate = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7930),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7931),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            SeatNumber = 0,
                            TicketNumber = "77083",
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7931),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            UserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        },
                        new
                        {
                            Id = new Guid("a3bc534e-8441-43a3-bc83-5ceabc69070d"),
                            BuyDate = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7944),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7945),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            SeatNumber = 0,
                            TicketNumber = "40092",
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7945),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            UserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        },
                        new
                        {
                            Id = new Guid("372ada54-8cfb-4475-8ec9-fcde8113901d"),
                            BuyDate = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7953),
                            CreatedDateTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7954),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            SeatNumber = 0,
                            TicketNumber = "78955",
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 75, DateTimeKind.Local).AddTicks(7955),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            UserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50")
                        });
                });

            modelBuilder.Entity("Model.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatedUserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VarChar");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVarChar");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVarChar");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("NVarChar");

                    b.Property<DateTime>("UpdatedDataTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UpdatedUserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VarChar");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("UpdatedUserId");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Email = "aa@gmail.com",
                            FirstName = "kiji",
                            LastName = "..",
                            Password = "123",
                            UpdatedDataTime = new DateTime(2024, 10, 3, 16, 32, 54, 83, DateTimeKind.Local).AddTicks(2586),
                            UpdatedUserId = new Guid("efe3a5f8-2198-4e31-899e-a3cd19e96d50"),
                            Username = "user1"
                        });
                });

            modelBuilder.Entity("Model.Entities.Address", b =>
                {
                    b.HasOne("Model.Entities.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("Model.Entities.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");

                    b.Navigation("City");

                    b.Navigation("CreatedUser");

                    b.Navigation("UpdatedUser");
                });

            modelBuilder.Entity("Model.Entities.City", b =>
                {
                    b.HasOne("Model.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("Model.Entities.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("Province");

                    b.Navigation("UpdatedUser");
                });

            modelBuilder.Entity("Model.Entities.Province", b =>
                {
                    b.HasOne("Model.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("Model.Entities.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("UpdatedUser");
                });

            modelBuilder.Entity("Model.Entities.Role", b =>
                {
                    b.HasOne("Model.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Model.Entities.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CreatedUser");

                    b.Navigation("UpdatedUser");
                });

            modelBuilder.Entity("Model.Entities.Ticket", b =>
                {
                    b.HasOne("Model.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Model.Entities.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Model.Entities.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedUser");

                    b.Navigation("UpdatedUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Entities.User", b =>
                {
                    b.HasOne("Model.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Model.Entities.User", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CreatedUser");

                    b.Navigation("UpdatedUser");
                });

            modelBuilder.Entity("Model.Entities.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Model.Entities.Province", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Model.Entities.User", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
