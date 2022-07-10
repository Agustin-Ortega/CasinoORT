﻿// <auto-generated />
using CasinoOrt.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CasinoOrt.Migrations
{
    [DbContext(typeof(CasinoContext))]
    [Migration("20220629234701_primera")]
    partial class primera
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CasinoOrt.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("monto")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("id");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}