﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nmnielsen.Repository.Domain;

#nullable disable

namespace nmnielsen.Repository.Migrations
{
    [DbContext(typeof(NMNielsenContext))]
    [Migration("20220307153440_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("nmnielsen.Repository.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imagename")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("No_Image_Icon.png");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsHidden")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("StatusMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "I marts 2022 bestemte jeg mig for at lave en hjemmeside, hvor jeg kunne dele min projecter og fortælle lidt om mig selv, dette er den hjemmeside du ser det her på. Formålet med projektet var bare som sagt at kunne vise hvad jeg har arbejdet med og for at kunne fortælle lidt om mig selv, men jeg lavede den også for at kunne få et sted jeg kunne bruge som et sandbox miljø til at øve og blive bedre til de ting jeg lære igennem tiden.",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Imagename = "nmnielsen_hjemmesiden.jpg",
                            IsDeleted = false,
                            IsHidden = false,
                            Name = "nmnielsen hjemmesiden",
                            ShortDescription = "Det her projekt er den side du er på lige nu.",
                            StartDate = new DateTime(2022, 3, 1, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusMessage = "Igangværende"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dette projekt er en app man kan bruge til at notere maskiner og andre ting ned i, da projektet lige er startet er der ikke så meget at skrive om det i nu. Hvad jeg kan skrive er at projektet er oprette da min far har efterspurgt en app han kunne bruge oppe på hans arbejde, så han kan holde log på de maskiner han har serviceret.",
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            IsHidden = false,
                            Name = "MachineNote App",
                            ShortDescription = "App til at notere maskiner og andre ting ned.",
                            StartDate = new DateTime(2022, 3, 2, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusMessage = "Planlagt"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
