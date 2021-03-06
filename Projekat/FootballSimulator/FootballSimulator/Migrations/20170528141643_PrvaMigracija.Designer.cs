﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FootballSimulator.Model;

namespace FootballSimulator.Migrations
{
    [DbContext(typeof(SimulatorContext))]
    [Migration("20170528141643_PrvaMigracija")]
    partial class PrvaMigracija
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("FootballSimulator.Model.Database.UtakmicaIgrac", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UtakmicaId");

                    b.HasKey("Id");

                    b.HasIndex("UtakmicaId");

                    b.ToTable("UtakmicaIgrac");
                });

            modelBuilder.Entity("FootballSimulator.Model.Igrac", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Att");

                    b.Property<double>("Cijena");

                    b.Property<int>("CleanSheet");

                    b.Property<int>("Def");

                    b.Property<int>("Gk");

                    b.Property<int>("Godine");

                    b.Property<string>("Ime");

                    b.Property<int>("Mid");

                    b.Property<int>("PostignutiGolovi");

                    b.Property<int>("Stamina");

                    b.Property<bool>("Suspendovan");

                    b.Property<int>("TimId");

                    b.HasKey("Id");

                    b.ToTable("Igraci");
                });

            modelBuilder.Entity("FootballSimulator.Model.Klub", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EkipaId");

                    b.Property<double>("Racun");

                    b.Property<string>("SezonaId");

                    b.Property<string>("StatistikaId");

                    b.HasKey("Id");

                    b.HasIndex("EkipaId");

                    b.HasIndex("SezonaId");

                    b.HasIndex("StatistikaId");

                    b.ToTable("Klubovi");
                });

            modelBuilder.Entity("FootballSimulator.Model.Kolo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Odigrano");

                    b.Property<int>("RedniBroj");

                    b.Property<string>("SezonaId");

                    b.HasKey("Id");

                    b.HasIndex("SezonaId");

                    b.ToTable("Kola");
                });

            modelBuilder.Entity("FootballSimulator.Model.Rezultat", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Domaci");

                    b.Property<int>("Gosti");

                    b.HasKey("Id");

                    b.ToTable("Rezultat");
                });

            modelBuilder.Entity("FootballSimulator.Model.Sezona", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MojKlub");

                    b.Property<int>("TrenutnoKolo");

                    b.Property<string>("VlasnikSezoneId");

                    b.HasKey("Id");

                    b.HasIndex("VlasnikSezoneId");

                    b.ToTable("Sezone");
                });

            modelBuilder.Entity("FootballSimulator.Model.StatistikaKluba", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bodovi");

                    b.Property<int>("Pobjede");

                    b.Property<int>("Porazi");

                    b.Property<int>("PostignutiGolovi");

                    b.Property<int>("PrimljeniGolovi");

                    b.Property<int>("Remi");

                    b.HasKey("Id");

                    b.ToTable("Statistike");
                });

            modelBuilder.Entity("FootballSimulator.Model.Tim", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Formacija");

                    b.Property<string>("KapitenId");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("KapitenId");

                    b.ToTable("Timovi");
                });

            modelBuilder.Entity("FootballSimulator.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FootballSimulator.Model.Utakmica", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DomaciId");

                    b.Property<string>("GostiId");

                    b.Property<string>("KoloId");

                    b.Property<bool>("Odigrana");

                    b.Property<string>("RezultatId");

                    b.HasKey("Id");

                    b.HasIndex("DomaciId");

                    b.HasIndex("GostiId");

                    b.HasIndex("KoloId");

                    b.HasIndex("RezultatId");

                    b.ToTable("Utakmice");
                });

            modelBuilder.Entity("FootballSimulator.Model.Database.UtakmicaIgrac", b =>
                {
                    b.HasOne("FootballSimulator.Model.Utakmica")
                        .WithMany("Strijelci")
                        .HasForeignKey("UtakmicaId");
                });

            modelBuilder.Entity("FootballSimulator.Model.Igrac", b =>
                {
                    b.HasOne("FootballSimulator.Model.Tim")
                        .WithMany("KlupaSastav")
                        .HasForeignKey("TimId");
                });

            modelBuilder.Entity("FootballSimulator.Model.Klub", b =>
                {
                    b.HasOne("FootballSimulator.Model.Tim", "Ekipa")
                        .WithMany()
                        .HasForeignKey("EkipaId");

                    b.HasOne("FootballSimulator.Model.Sezona")
                        .WithMany("Timovi")
                        .HasForeignKey("SezonaId");

                    b.HasOne("FootballSimulator.Model.StatistikaKluba", "Statistika")
                        .WithMany()
                        .HasForeignKey("StatistikaId");
                });

            modelBuilder.Entity("FootballSimulator.Model.Kolo", b =>
                {
                    b.HasOne("FootballSimulator.Model.Sezona")
                        .WithMany("Kola")
                        .HasForeignKey("SezonaId");
                });

            modelBuilder.Entity("FootballSimulator.Model.Sezona", b =>
                {
                    b.HasOne("FootballSimulator.Model.User", "VlasnikSezone")
                        .WithMany()
                        .HasForeignKey("VlasnikSezoneId");
                });

            modelBuilder.Entity("FootballSimulator.Model.Tim", b =>
                {
                    b.HasOne("FootballSimulator.Model.Igrac", "Kapiten")
                        .WithMany()
                        .HasForeignKey("KapitenId");
                });

            modelBuilder.Entity("FootballSimulator.Model.Utakmica", b =>
                {
                    b.HasOne("FootballSimulator.Model.Tim", "Domaci")
                        .WithMany()
                        .HasForeignKey("DomaciId");

                    b.HasOne("FootballSimulator.Model.Tim", "Gosti")
                        .WithMany()
                        .HasForeignKey("GostiId");

                    b.HasOne("FootballSimulator.Model.Kolo")
                        .WithMany("Utakmice")
                        .HasForeignKey("KoloId");

                    b.HasOne("FootballSimulator.Model.Rezultat", "Rezultat")
                        .WithMany()
                        .HasForeignKey("RezultatId");
                });
        }
    }
}
