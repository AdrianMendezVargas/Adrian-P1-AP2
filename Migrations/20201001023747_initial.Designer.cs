﻿// <auto-generated />
using Adrian_P1_AP2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Adrian_P1_AP2.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20201001023747_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Adrian_P1_AP2.Models.TipoCliente", b =>
                {
                    b.Property<int>("TipoClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TipoClienteId");

                    b.ToTable("TipoClientes");
                });
#pragma warning restore 612, 618
        }
    }
}