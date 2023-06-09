﻿// <auto-generated />
using System;
using Locacao.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Locacao.Migrations
{
    [DbContext(typeof(LocacaoContext))]
    partial class LocacaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Locacao.Model.CarroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_LOCACAO");

                    b.Property<int?>("MarcaID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.HasIndex("MarcaID");

                    b.ToTable("CARRO");
                });

            modelBuilder.Entity("Locacao.Model.MarcaModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOME");

                    b.HasKey("ID");

                    b.ToTable("MARCA");
                });

            modelBuilder.Entity("Locacao.Model.CarroModel", b =>
                {
                    b.HasOne("Locacao.Model.MarcaModel", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaID");

                    b.Navigation("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}
