// <auto-generated />
using System;
using MVC_Vaje202122_Priprava.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Vaje202122_Priprava.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220103111227_UstvariBazo")]
    partial class UstvariBazo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Vaje202122_Priprava.Models.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ustvarjeno")
                        .HasColumnType("datetime2");

                    b.Property<int>("vrstniRed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kategorije");
                });
#pragma warning restore 612, 618
        }
    }
}
