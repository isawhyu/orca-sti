﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product_Inventory_ILA.DAL;

#nullable disable

namespace Product_Inventory_ILA.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20240616112539_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Product_Inventory_ILA.Models.DBEntities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
