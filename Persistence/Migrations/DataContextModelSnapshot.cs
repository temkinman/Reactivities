﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Db;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("918039f9-d583-4cf6-ad8f-bd3b9025dc34"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 1, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9016),
                            Description = "Activity 2 months ago",
                            IsCancelled = false,
                            Title = "Past Activity 1",
                            Venue = "Pub"
                        },
                        new
                        {
                            Id = new Guid("7f28bc88-cc7b-4bd1-a404-130f25e5ce3a"),
                            Category = "culture",
                            City = "Paris",
                            Date = new DateTime(2023, 2, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9025),
                            Description = "Activity 1 month ago",
                            IsCancelled = false,
                            Title = "Past Activity 2",
                            Venue = "Louvre"
                        },
                        new
                        {
                            Id = new Guid("776f5bde-66e4-4668-86cd-f9312e7aea02"),
                            Category = "culture",
                            City = "London",
                            Date = new DateTime(2023, 4, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9028),
                            Description = "Activity 1 month in future",
                            IsCancelled = false,
                            Title = "Future Activity 1",
                            Venue = "Natural History Museum"
                        },
                        new
                        {
                            Id = new Guid("398cba62-4b07-4c11-973a-1205db025fc0"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2023, 5, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9031),
                            Description = "Activity 2 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 2",
                            Venue = "O2 Arena"
                        },
                        new
                        {
                            Id = new Guid("8ed59834-b2cf-4d38-9578-ec324037d25f"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 6, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9044),
                            Description = "Activity 3 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 3",
                            Venue = "Another pub"
                        },
                        new
                        {
                            Id = new Guid("ebb06d95-2c82-424b-8911-d47f0f4a0424"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 7, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9046),
                            Description = "Activity 4 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 4",
                            Venue = "Yet another pub"
                        },
                        new
                        {
                            Id = new Guid("bfa06c66-f1e5-4f57-9771-af732ce8c93c"),
                            Category = "drinks",
                            City = "London",
                            Date = new DateTime(2023, 8, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9049),
                            Description = "Activity 5 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 5",
                            Venue = "Just another pub"
                        },
                        new
                        {
                            Id = new Guid("1301565a-484b-4039-8bce-4ae2cc3342eb"),
                            Category = "music",
                            City = "London",
                            Date = new DateTime(2023, 9, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9051),
                            Description = "Activity 6 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 6",
                            Venue = "Roundhouse Camden"
                        },
                        new
                        {
                            Id = new Guid("1f0720d2-88a2-4af8-aed0-64521833baea"),
                            Category = "travel",
                            City = "London",
                            Date = new DateTime(2023, 10, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9053),
                            Description = "Activity 2 months ago",
                            IsCancelled = false,
                            Title = "Future Activity 7",
                            Venue = "Somewhere on the Thames"
                        },
                        new
                        {
                            Id = new Guid("8a367040-95fc-4fff-875c-ec5c5354056f"),
                            Category = "film",
                            City = "London",
                            Date = new DateTime(2023, 11, 28, 18, 55, 44, 325, DateTimeKind.Utc).AddTicks(9054),
                            Description = "Activity 8 months in future",
                            IsCancelled = false,
                            Title = "Future Activity 8",
                            Venue = "Cinema"
                        });
                });

            modelBuilder.Entity("Domain.Entities.ActivityAttendee", b =>
                {
                    b.Property<string>("AppUserId")
                        .HasColumnType("text");

                    b.Property<Guid>("ActivityId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsHost")
                        .HasColumnType("boolean");

                    b.HasKey("AppUserId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityAttendees");
                });

            modelBuilder.Entity("Domain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ActivityAttendee", b =>
                {
                    b.HasOne("Domain.Entities.Activity", "Activity")
                        .WithMany("Attendees")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("Activities")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Activity", b =>
                {
                    b.Navigation("Attendees");
                });

            modelBuilder.Entity("Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
