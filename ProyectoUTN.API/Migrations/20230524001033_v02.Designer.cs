﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProyectoUTN.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230524001033_v02")]
    partial class v02
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("ProyectoUTN.Modelos.Categoria", b =>
                {
                    b.Property<int>("CodigoCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CodigoCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProyectoUTN.Modelos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoriaCodigoCategoria")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("precio")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaCodigoCategoria");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ProyectoUTN.Modelos.Producto", b =>
                {
                    b.HasOne("ProyectoUTN.Modelos.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaCodigoCategoria");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ProyectoUTN.Modelos.Categoria", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
