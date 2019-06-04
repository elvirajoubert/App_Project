﻿// <auto-generated />
using System;
using AppPrawject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppPrawject.Data.Migrations
{
    [DbContext(typeof(AppPrawjectDbContext))]
    [Migration("20190604015447_added-servicepet-identity-roles")]
    partial class addedservicepetidentityroles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppPrawject.Domain.Model.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AppPrawject.Domain.Model.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PetBreedId");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("PetBreedId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("AppPrawject.Domain.Model.PetBreed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("PetBreeds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Labrador"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Chihuahua"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Poodle"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Beagle"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Mixed Breed"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Boston Terrier"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Collie"
                        },
                        new
                        {
                            Id = 8,
                            Description = "French Bulldog"
                        },
                        new
                        {
                            Id = 9,
                            Description = "German Shepherd"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Pug"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Bulldog"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Siberian Husky"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Great Dane"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Rottweiler"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Yorkshire Terrier"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Golden Retriever"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Boxer"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Australian Shepherd"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Bichon Frise"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Chow Chow"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Pointer"
                        },
                        new
                        {
                            Id = 22,
                            Description = "Dachshund"
                        },
                        new
                        {
                            Id = 23,
                            Description = "Pomeranian"
                        },
                        new
                        {
                            Id = 24,
                            Description = "Pembroke Welsh Corgi"
                        },
                        new
                        {
                            Id = 25,
                            Description = "Bernese Mountain Dog"
                        },
                        new
                        {
                            Id = 26,
                            Description = "Basset Hound"
                        },
                        new
                        {
                            Id = 27,
                            Description = "Greyhound"
                        },
                        new
                        {
                            Id = 28,
                            Description = "American Staffordshire Terrier"
                        },
                        new
                        {
                            Id = 29,
                            Description = "Jack Russell Terrier"
                        },
                        new
                        {
                            Id = 30,
                            Description = "Australian Cattle Dog"
                        },
                        new
                        {
                            Id = 31,
                            Description = "Alaskan Malamute"
                        },
                        new
                        {
                            Id = 32,
                            Description = "Akita"
                        },
                        new
                        {
                            Id = 33,
                            Description = "American Foxhound"
                        },
                        new
                        {
                            Id = 34,
                            Description = "Vizsla"
                        },
                        new
                        {
                            Id = 35,
                            Description = "Scottish Terrier"
                        },
                        new
                        {
                            Id = 36,
                            Description = "Weimaraner"
                        },
                        new
                        {
                            Id = 37,
                            Description = "Doberman"
                        },
                        new
                        {
                            Id = 38,
                            Description = "Bullterrier"
                        },
                        new
                        {
                            Id = 39,
                            Description = "English Mastiff"
                        },
                        new
                        {
                            Id = 40,
                            Description = "Pitbull"
                        });
                });

            modelBuilder.Entity("AppPrawject.Domain.Model.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("PetBreedId");

                    b.Property<int?>("PetId");

                    b.Property<string>("ServiceType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PetBreedId = 0,
                            ServiceType = "Boarding",
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PetBreedId = 0,
                            ServiceType = "Grooming",
                            UserId = "2"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PetBreedId = 0,
                            ServiceType = "Both",
                            UserId = "3"
                        });
                });

            modelBuilder.Entity("AppPrawject.Domain.Model.ServicePet", b =>
                {
                    b.Property<int>("PetId");

                    b.Property<int>("ServiceId");

                    b.HasKey("PetId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("ServicePet");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "f5cbe7c9-958d-41d0-8e96-7b994c5dd0c0",
                            ConcurrencyStamp = "98fcb7bd-b927-42e5-a3e4-317fd6b98521",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "c4a4e680-3db9-4be8-928a-9fb13d49e2cb",
                            ConcurrencyStamp = "d39108fd-32a8-426e-a6c8-ab8f9c7e8620",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AppPrawject.Domain.Model.Pet", b =>
                {
                    b.HasOne("AppPrawject.Domain.Model.AppUser", "Admin")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("AppPrawject.Domain.Model.PetBreed", "PetBreed")
                        .WithMany()
                        .HasForeignKey("PetBreedId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AppPrawject.Domain.Model.Service", b =>
                {
                    b.HasOne("AppPrawject.Domain.Model.Pet", "Pet")
                        .WithMany("ServiceType")
                        .HasForeignKey("PetId");

                    b.HasOne("AppPrawject.Domain.Model.AppUser", "User")
                        .WithMany("Services")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AppPrawject.Domain.Model.ServicePet", b =>
                {
                    b.HasOne("AppPrawject.Domain.Model.Pet", "Pet")
                        .WithMany("ServicePets")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppPrawject.Domain.Model.Service", "Service")
                        .WithMany("ServicePets")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AppPrawject.Domain.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AppPrawject.Domain.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AppPrawject.Domain.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AppPrawject.Domain.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
