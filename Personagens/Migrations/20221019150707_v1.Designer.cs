﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Personagens.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221019150707_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Personagens.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Altura")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("DataEstreia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsAlive")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Personagem", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Altura = 1.6000000000000001,
                            DataEstreia = new DateTime(2018, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAlive = true,
                            Nome = "Entrapta"
                        },
                        new
                        {
                            Id = 2,
                            Altura = 1.71,
                            DataEstreia = new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAlive = false,
                            Nome = "Rhaenyra Targaryen"
                        },
                        new
                        {
                            Id = 3,
                            Altura = 1.6599999999999999,
                            DataEstreia = new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAlive = true,
                            Nome = "Alicent Hightower"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
