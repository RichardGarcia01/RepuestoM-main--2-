﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepuestoM.Server.Context;

#nullable disable

namespace RepuestoM.Server.Migrations
{
    [DbContext(typeof(RepuestosDBContext))]
    partial class RepuestosDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RespuestoM.Server.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioRolId")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioRolId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("RespuestoM.Server.Models.UsuarioRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PermisoParaCrear")
                        .HasColumnType("bit");

                    b.Property<bool>("PermisoParaEditar")
                        .HasColumnType("bit");

                    b.Property<bool>("PermisoParaEliminar")
                        .HasColumnType("bit");

                    b.Property<int?>("UsuarioRolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioRolId");

                    b.ToTable("UsuarioRol");
                });

            modelBuilder.Entity("RespuestoM.Server.Models.Usuario", b =>
                {
                    b.HasOne("RespuestoM.Server.Models.UsuarioRol", "UsuarioRol")
                        .WithMany()
                        .HasForeignKey("UsuarioRolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioRol");
                });

            modelBuilder.Entity("RespuestoM.Server.Models.UsuarioRol", b =>
                {
                    b.HasOne("RespuestoM.Server.Models.UsuarioRol", null)
                        .WithMany("Usuarios")
                        .HasForeignKey("UsuarioRolId");
                });

            modelBuilder.Entity("RespuestoM.Server.Models.UsuarioRol", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
