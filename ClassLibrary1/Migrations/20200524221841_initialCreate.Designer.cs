﻿// <auto-generated />
using System;
using ClassLibrary1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassLibrary1.Migrations
{
    [DbContext(typeof(TeamsContext))]
    [Migration("20200524221841_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassLibrary1.Speler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rugnummer")
                        .HasColumnType("int");

                    b.Property<double>("TransferWaarde")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Spelers");
                });

            modelBuilder.Entity("ClassLibrary1.Team", b =>
                {
                    b.Property<int>("Stamnummer")
                        .HasColumnType("int");

                    b.Property<string>("Bijnaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainerNaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Stamnummer");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("ClassLibrary1.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NieuwTeamStamnummer")
                        .HasColumnType("int");

                    b.Property<int?>("OudTeamStamnummer")
                        .HasColumnType("int");

                    b.Property<double>("Prijs")
                        .HasColumnType("float");

                    b.Property<int?>("spelerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NieuwTeamStamnummer");

                    b.HasIndex("OudTeamStamnummer");

                    b.HasIndex("spelerId");

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("ClassLibrary1.Transfer", b =>
                {
                    b.HasOne("ClassLibrary1.Team", "NieuwTeam")
                        .WithMany()
                        .HasForeignKey("NieuwTeamStamnummer");

                    b.HasOne("ClassLibrary1.Team", "OudTeam")
                        .WithMany()
                        .HasForeignKey("OudTeamStamnummer");

                    b.HasOne("ClassLibrary1.Speler", "speler")
                        .WithMany()
                        .HasForeignKey("spelerId");
                });
#pragma warning restore 612, 618
        }
    }
}
