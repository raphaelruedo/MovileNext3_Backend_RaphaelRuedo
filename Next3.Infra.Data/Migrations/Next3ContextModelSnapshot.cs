﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Next3.Infra.Data.Context;

namespace Next3.Infra.Data.Migrations
{
    [DbContext(typeof(Next3Context))]
    partial class Next3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Next3.Domain.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longitude");

                    b.Property<int>("Number");

                    b.Property<Guid>("RestaurantId");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Next3.Domain.Models.Expertise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Expertise");
                });

            modelBuilder.Entity("Next3.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.Property<Guid>("RestaurantId");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Next3.Domain.Models.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<Guid>("ExpertiseId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ExpertiseId");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("Next3.Domain.Models.Address", b =>
                {
                    b.HasOne("Next3.Domain.Models.Restaurant", "Restaurant")
                        .WithOne("Address")
                        .HasForeignKey("Next3.Domain.Models.Address", "RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Next3.Domain.Models.Product", b =>
                {
                    b.HasOne("Next3.Domain.Models.Restaurant", "Restaurant")
                        .WithMany("Products")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Next3.Domain.Models.Restaurant", b =>
                {
                    b.HasOne("Next3.Domain.Models.Expertise", "Expertise")
                        .WithMany("Restaurants")
                        .HasForeignKey("ExpertiseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
