﻿// <auto-generated />
using System;
using API.Paises.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Paises.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Paises.Entidades.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaEdicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("paisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("paisId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("API.Paises.Entidades.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaEdicion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("API.Paises.Entidades.Estado", b =>
                {
                    b.HasOne("API.Paises.Entidades.Pais", "pais")
                        .WithMany("Estado")
                        .HasForeignKey("paisId");

                    b.Navigation("pais");
                });

            modelBuilder.Entity("API.Paises.Entidades.Pais", b =>
                {
                    b.Navigation("Estado");
                });
#pragma warning restore 612, 618
        }
    }
}
