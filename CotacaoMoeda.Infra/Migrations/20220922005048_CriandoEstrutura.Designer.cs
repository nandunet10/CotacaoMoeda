﻿// <auto-generated />
using System;
using CotacaoMoeda.Infra.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CotacaoMoeda.Infra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220922005048_CriandoEstrutura")]
    partial class CriandoEstrutura
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CotacaoMoeda.Models.Cotacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataHoraCotacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("ValorCompra")
                        .HasColumnType("decimal(15,5)");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(15,5)");

                    b.HasKey("Id");

                    b.ToTable("Cotacao");
                });
#pragma warning restore 612, 618
        }
    }
}