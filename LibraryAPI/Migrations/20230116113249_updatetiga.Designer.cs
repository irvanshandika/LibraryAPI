﻿// <auto-generated />
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAPI.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20230116113249_updatetiga")]
    partial class updatetiga
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryAPI.Models.Akun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nama_belakang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama_depan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Akuns");
                });

            modelBuilder.Entity("LibraryAPI.Models.Buku", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gambar_buku")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kategori_buku")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nama_buku")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Penulis_buku")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status_buku")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("bukus");
                });
#pragma warning restore 612, 618
        }
    }
}
