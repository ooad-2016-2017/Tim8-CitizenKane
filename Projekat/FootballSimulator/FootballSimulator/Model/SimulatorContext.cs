using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace FootballSimulator.Model
{
    class SimulatorContext : DbContext
    {
        public DbSet<Tim> Timovi { get; set; }
        public DbSet<Igrac> Igraci { get; set; }
        public DbSet<Sezona> Sezone { get; set; }
        public DbSet<Klub> Klubovi { get; set; }
        public DbSet<StatistikaKluba> Statistike { get; set; }
        public DbSet<Kolo> Kola { get; set; }
        public DbSet<Utakmica> Utakmice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "FootballSimulator.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,
                databaseFilePath);
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Foreign keys

        }
    }
}
