﻿// <auto-generated />
using CasinoOrt.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CasinoOrt.Migrations
{
    [DbContext(typeof(CasinoContext))]
    partial class CasinoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CasinoOrt.Models.Informe", b =>
                {
                    b.Property<int>("InformeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantGanadas")
                        .HasColumnType("int");

                    b.Property<int>("cantPerdidas")
                        .HasColumnType("int");

                    b.Property<int>("ganancia")
                        .HasColumnType("int");

                    b.Property<int>("montoInicial")
                        .HasColumnType("int");

                    b.Property<int>("montoPerdida")
                        .HasColumnType("int");

                    b.HasKey("InformeId");

                    b.ToTable("informes");
                });

            modelBuilder.Entity("CasinoOrt.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InformeId")
                        .HasColumnType("int");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("InformeId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("CasinoOrt.Models.Usuario", b =>
                {
                    b.HasOne("CasinoOrt.Models.Informe", "Informe")
                        .WithMany()
                        .HasForeignKey("InformeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
