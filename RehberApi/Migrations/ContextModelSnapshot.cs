﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RehberApi.DataAccessLayer;

namespace RehberApi.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("RehberApi.Iletisim", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Konum")
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Iletisims");
                });

            modelBuilder.Entity("RehberApi.Rehber", b =>
                {
                    b.Property<int>("UUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<string>("Firma")
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .HasColumnType("text");

                    b.Property<int?>("iletisimID")
                        .HasColumnType("integer");

                    b.HasKey("UUID");

                    b.HasIndex("iletisimID");

                    b.ToTable("Rehbers");
                });

            modelBuilder.Entity("RehberApi.Rehber", b =>
                {
                    b.HasOne("RehberApi.Iletisim", "iletisim")
                        .WithMany()
                        .HasForeignKey("iletisimID");

                    b.Navigation("iletisim");
                });
#pragma warning restore 612, 618
        }
    }
}
