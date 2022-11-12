﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonVoyageApi.Database;

#nullable disable

namespace MonVoyageApi.Migrations
{
    [DbContext(typeof(DestinoDbContext))]
    [Migration("20221110133849_AtualizaDestino")]
    partial class AtualizaDestino
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MonVoyageApi.Model.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("cidade");

                    b.Property<string>("EstadoPaisNome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("estado_pais");

                    b.HasKey("Id");

                    b.ToTable("destinos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
