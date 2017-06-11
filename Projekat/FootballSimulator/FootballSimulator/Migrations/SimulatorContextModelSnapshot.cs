using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FootballSimulator.Model;

namespace FootballSimulator.Migrations
{
    [DbContext(typeof(SimulatorContext))]
    partial class SimulatorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Ime");

                    b.Property<double>("Cijena");

                    b.Property<int>("Godine");

                    b.Property<int>("Att");

                    b.Property<int>("Mid");

                    b.Property<int>("Def");

                    b.Property<int>("Gk");

                    b.Property<int>("CleanSheet");

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
        }
    }
}
