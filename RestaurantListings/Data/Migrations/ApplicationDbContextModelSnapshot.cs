﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantListings.Data;

namespace RestaurantListings.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RestaurantListings.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RestaurantListings.Data.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Stars")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("RestaurantListings.Data.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool>("FamilyFriendly")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoUri")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<bool>("VeganFriendly")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "331 Roundhay Road, Harehills, Leeds, LS8 4HT",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent condimentum convallis arcu, vel iaculis tortor. Pellentesque eu ex libero. Vestibulum sit amet lacus lacinia, sagittis odio sit amet, bibendum ipsum. Quisque bibendum rutrum feugiat. Aenean sodales finibus posuere. Cras aliquam a elit vel sagittis. Donec ac libero ex. Quisque nec sapien augue. Vivamus non ipsum a dolor mollis tincidunt vel eget enim. Sed consectetur sem tempus euismod ultricies.",
                            FamilyFriendly = false,
                            Name = "Yokohama",
                            PhoneNumber = "+44-011-355-5011",
                            PhotoUri = "/images/yokohama.jpg",
                            Rating = 5.0m,
                            Tags = "[\"Japanese\",\"Asian\",\"Healthy\"]",
                            VeganFriendly = true
                        },
                        new
                        {
                            Id = 2,
                            Address = "50 Briggate, Leeds, LS1 6HD",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ornare mauris sed tortor sodales, sed dapibus mauris maximus. Aliquam quis consectetur nisl. Pellentesque nec lacus erat. In nec tristique justo, at pulvinar quam. Suspendisse finibus mi sit amet rhoncus pharetra. Phasellus finibus augue ac molestie imperdiet. Quisque ac rhoncus lorem, sed vestibulum felis. Maecenas pharetra enim justo, et faucibus ex aliquet ut. Integer congue malesuada luctus. Donec egestas, libero eu consequat consequat, orci magna dictum erat, at auctor magna sem et lectus. Mauris vehicula ornare risus eget posuere. Curabitur eget ultricies purus. Pellentesque ac justo vehicula, congue arcu sed, varius sapien.",
                            FamilyFriendly = true,
                            Name = "Falafel Guys",
                            PhoneNumber = "+44-011-355-5337",
                            PhotoUri = "/images/falafel.jpg",
                            Rating = 4.5m,
                            Tags = "[\"Fast food\",\"Healthy\",\"British\"]",
                            VeganFriendly = true
                        },
                        new
                        {
                            Id = 3,
                            Address = "65 Haddon Road, Burley, Leeds, LS4 2JE",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam dictum justo eget massa rutrum, at scelerisque ipsum fringilla. Curabitur aliquam augue tellus, ac feugiat massa volutpat eget. Praesent fringilla accumsan purus, vitae interdum eros tempus vitae. Sed malesuada pharetra tristique. Sed vel consectetur nunc. Fusce mattis egestas libero non auctor. Phasellus aliquam ex eu accumsan rhoncus. Sed sed ex ut massa facilisis finibus. Vestibulum sed mauris eget sapien vestibulum viverra at nec ex. Integer eleifend malesuada rhoncus.",
                            FamilyFriendly = true,
                            Name = "Bengal Brasserie",
                            PhoneNumber = "+44-011-355-5564",
                            PhotoUri = "/images/bengal.jpg",
                            Rating = 4.0m,
                            Tags = "[\"Indian\",\"Asian\",\"Bar\"]",
                            VeganFriendly = true
                        },
                        new
                        {
                            Id = 4,
                            Address = "21-22 Park Row, Leeds, LS1 5JF",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus venenatis venenatis velit. In hac habitasse platea dictumst. Vivamus a venenatis dui. Praesent non magna consectetur, tristique mi in, volutpat nulla. Proin risus mauris, ultricies nec fermentum ac, pretium in turpis. Aliquam erat volutpat. Fusce semper neque urna, nec lobortis lorem placerat dictum. Sed ac lobortis lectus. Proin pharetra neque quis purus blandit vestibulum. Aenean lobortis, libero fringilla cursus malesuada, dolor nisl pulvinar felis, quis mollis lacus nisl fringilla arcu. Donec eget maximus urna. Etiam vitae velit nulla. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; In tristique non dui ac pretium. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.",
                            FamilyFriendly = false,
                            Name = "Gaucho",
                            PhoneNumber = "+44-011-355-5456",
                            PhotoUri = "/images/gaucho.jpg",
                            Rating = 3.0m,
                            Tags = "[\"Steakhouse\",\"Argentinian\",\"Bar\"]",
                            VeganFriendly = false
                        },
                        new
                        {
                            Id = 5,
                            Address = "342 Kirkstall Road, Leeds, LS4 2DS",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam sagittis tortor vel sem blandit, eget dignissim dolor porttitor. Morbi elementum lectus vitae velit elementum, quis porta purus porta. Morbi a tincidunt risus. Nam vitae enim sit amet metus imperdiet finibus. Duis id nisl sed nunc bibendum condimentum. Nunc faucibus porta leo. Ut hendrerit odio sed elit lobortis, eu euismod lacus egestas. Vivamus lacus odio, laoreet non turpis in, porttitor luctus tortor.",
                            FamilyFriendly = true,
                            Name = "Viva Cuba",
                            PhoneNumber = "+44-011-355-5894",
                            PhotoUri = "/images/viva.jpg",
                            Rating = 4.2m,
                            Tags = "[\"Latin\",\"Spanish\",\"Cuban\"]",
                            VeganFriendly = true
                        },
                        new
                        {
                            Id = 6,
                            Address = "82 North Street, Leeds, LS2 7PN",
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam egestas sapien vel augue consectetur laoreet. Aliquam consequat purus non nibh euismod sollicitudin vitae id eros. Donec vehicula odio eu malesuada sollicitudin. Cras pulvinar elit nec urna sagittis, id convallis arcu tristique. Mauris vulputate sem in ornare vulputate. Donec dictum est sit amet neque laoreet, in dictum ex facilisis. Quisque porta lectus ac libero sodales consectetur. Nullam non pharetra eros, in scelerisque diam. Sed malesuada tellus in risus gravida, eu sagittis nibh pretium.",
                            FamilyFriendly = true,
                            Name = "The Brunswick",
                            PhoneNumber = "+44-011-355-5955",
                            PhotoUri = "/images/brunswick.jpg",
                            Rating = 3.7m,
                            Tags = "[\"Bar\",\"British\",\"Pub\"]",
                            VeganFriendly = true
                        });
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
                    b.HasOne("RestaurantListings.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RestaurantListings.Data.Entities.ApplicationUser", null)
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

                    b.HasOne("RestaurantListings.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RestaurantListings.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
