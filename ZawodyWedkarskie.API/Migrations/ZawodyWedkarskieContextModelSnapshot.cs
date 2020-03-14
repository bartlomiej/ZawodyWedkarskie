﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZawodyWedkarskie.API.Data;

namespace ZawodyWedkarskie.API.Migrations
{
    [DbContext(typeof(ZawodyWedkarskieContext))]
    partial class ZawodyWedkarskieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZawodyWedkarskie.API.Models.KoloWedkarskie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KolaWedkarskie");
                });

            modelBuilder.Entity("ZawodyWedkarskie.API.Models.Uzytkownik", b =>
                {
                    b.Property<int>("IdUzytkownika")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktywny")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataModyfikacji")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataUtworzenia")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<byte[]>("HasloHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("HasloSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("NrKartyWedkarskiej")
                        .HasColumnType("NVARCHAR(30)");

                    b.Property<string>("UzytkownikModyfikowal")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("UzytkownikUtworzyl")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(70)");

                    b.HasKey("IdUzytkownika");

                    b.ToTable("Uzytkownicy");
                });
#pragma warning restore 612, 618
        }
    }
}
