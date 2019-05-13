﻿// <auto-generated />
using AppPrawject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppPrawject.Data.Migrations
{
    [DbContext(typeof(AppPrawjectDbContext))]
    [Migration("20190509002728_add-pet-breed-with-seeding")]
    partial class addpetbreedwithseeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        });
                });

            modelBuilder.Entity("AppPrawject.Domain.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Breed")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}