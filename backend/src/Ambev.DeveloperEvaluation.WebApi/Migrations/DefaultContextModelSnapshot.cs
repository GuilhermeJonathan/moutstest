﻿// <auto-generated />
using System;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ambev.DeveloperEvaluation.WebApi.Migrations
{
    [DbContext(typeof(DefaultContext))]
    partial class DefaultContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.User", b =>
                {
                    b.OwnsOne("Ambev.DeveloperEvaluation.Domain.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasColumnName("City");

                            b1.Property<int>("Number")
                                .HasColumnType("INTEGER")
                                .HasColumnName("Number");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasColumnName("Street");

                            b1.Property<string>("Zipcode")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasColumnName("Zipcode");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");

                            b1.OwnsOne("Ambev.DeveloperEvaluation.Domain.Entities.Geolocation", "Geolocation", b2 =>
                                {
                                    b2.Property<Guid>("AddressUserId")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("uuid");

                                    b2.Property<string>("Lat")
                                        .IsRequired()
                                        .HasColumnType("TEXT")
                                        .HasColumnName("Lat");

                                    b2.Property<string>("Long")
                                        .IsRequired()
                                        .HasColumnType("TEXT")
                                        .HasColumnName("Long");

                                    b2.HasKey("AddressUserId");

                                    b2.ToTable("Users");

                                    b2.WithOwner()
                                        .HasForeignKey("AddressUserId");
                                });

                            b1.Navigation("Geolocation")
                                .IsRequired();
                        });

                    b.OwnsOne("Ambev.DeveloperEvaluation.Domain.Entities.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid");

                            b1.Property<string>("Firstname")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasColumnName("Firstname");

                            b1.Property<string>("Lastname")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasColumnName("Lastname");

                            b1.HasKey("UserId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
