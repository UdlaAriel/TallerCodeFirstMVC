﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerCodeFirstMVC.Data;

#nullable disable

namespace TallerCodeFirstMVC.Migrations
{
    [DbContext(typeof(TallerCodeFirstMVCContext))]
    [Migration("20241021232204_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TallerCodeFirstMVC.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("ForeignAccept")
                        .HasColumnType("bit");

                    b.Property<int>("IdEstadio")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Titles")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int?>("estadioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("estadioId");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("TallerCodeFirstMVC.Models.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("TallerCodeFirstMVC.Models.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idEquipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("idEquipo");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("TallerCodeFirstMVC.Models.Equipo", b =>
                {
                    b.HasOne("TallerCodeFirstMVC.Models.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioId");

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("TallerCodeFirstMVC.Models.Jugador", b =>
                {
                    b.HasOne("TallerCodeFirstMVC.Models.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("idEquipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });
#pragma warning restore 612, 618
        }
    }
}
