﻿// <auto-generated />
using System;
using BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220605152152_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("BackEnd.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("BackEnd.Models.Contenido", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaDeSubida")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("PesoEnMB")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Contenidos");
                });

            modelBuilder.Entity("BackEnd.Models.Listado", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContenidoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("ContenidoID");

                    b.ToTable("Listados");
                });

            modelBuilder.Entity("BackEnd.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Contraseña")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BackEnd.Models.Contenido", b =>
                {
                    b.HasOne("BackEnd.Models.Usuario", "Usuarios")
                        .WithMany("Contenidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("BackEnd.Models.Listado", b =>
                {
                    b.HasOne("BackEnd.Models.Categoria", "Categoria")
                        .WithMany("Listados")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BackEnd.Models.Contenido", "Contenido")
                        .WithMany("Listados")
                        .HasForeignKey("ContenidoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Contenido");
                });

            modelBuilder.Entity("BackEnd.Models.Categoria", b =>
                {
                    b.Navigation("Listados");
                });

            modelBuilder.Entity("BackEnd.Models.Contenido", b =>
                {
                    b.Navigation("Listados");
                });

            modelBuilder.Entity("BackEnd.Models.Usuario", b =>
                {
                    b.Navigation("Contenidos");
                });
#pragma warning restore 612, 618
        }
    }
}