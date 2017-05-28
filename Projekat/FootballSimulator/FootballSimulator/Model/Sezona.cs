using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Sezona
    {
        // Atributi
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;
        List<Klub> timovi;
        List<Kolo> kola;
        int mojKlub; // indeks kluba u listi klubova (trebalo bi namjestiti da je 0)
        int trenutnoKolo;

        private User vlasnikSezone;

        // Properties
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public List<Klub> Timovi
        {
            get
            {
                return timovi;
            }

            set
            {
                timovi = value;
            }
        }
        public List<Kolo> Kola
        {
            get
            {
                return kola;
            }

            set
            {
                kola = value;
            }
        }
        public int MojKlub
        {
            get
            {
                return mojKlub;
            }

            set
            {
                mojKlub = value;
            }
        }
        public int TrenutnoKolo
        {
            get
            {
                return trenutnoKolo;
            }

            set
            {
                trenutnoKolo = value;
            }
        }

        public User VlasnikSezone { get => vlasnikSezone; set => vlasnikSezone = value; }


        // Konstruktori
        public Sezona(User u)
        {
            this.timovi = new List<Klub>();
            this.kola = new List<Kolo>();
            this.mojKlub = 0;
            trenutnoKolo = 1; // kolo koje ce se sljedece odigrati
            VlasnikSezone = u;
        }
        public Sezona(User u, List<Klub> timovi, List<Kolo> kola, int mojKlub, int trenutnoKolo)
        {
            this.timovi = timovi;
            this.kola = kola;
            this.mojKlub = mojKlub;
            this.trenutnoKolo = trenutnoKolo;
            VlasnikSezone = u;
        }
        public Sezona(User u, Klub mojTim, List<Klub> ostaliTimovi)
        {
            this.timovi = ostaliTimovi;
            this.kola = generisiKola();
            this.mojKlub = ostaliTimovi.FindIndex((x) => x.Id == mojTim.Id);
            this.trenutnoKolo = 0;
            VlasnikSezone = u;
        }

        // Metode
        public List<StatistikaKluba> dajTabelu()
        {
            List<StatistikaKluba> lista = new List<StatistikaKluba>();
            foreach(Klub k in timovi)
            {
                lista.Add(k.Statistika);
            }
            return lista;
        }
        public Kolo dajTrenutnoKolo()
        {
            return kola[trenutnoKolo - 1]; // lista pocinje od 0 a kola od 1
        }
        public Kolo dajSljedeceKolo()
        {
            if (dajUkupanBrojKola() > trenutnoKolo)
                return kola[trenutnoKolo];
            else
                return kola[trenutnoKolo - 1];
        }
        public Kolo dajNKolo(int brojKola)
        {
            return kola[brojKola];
        }
        public int dajUkupanBrojKola()
        {
            return timovi.Count * 2 - 2;
        }
        public List<Kolo> generisiKola()
        {
            // dodati algoritam za generisanje kola
            return new List<Kolo>(); // privremeno da kompajlira :(

        }
        public List<Igrac> najboljiStrijelci()
        {
            List<Igrac> strijelci = new List<Igrac>();
            for(int i = 0; i < timovi.Count; i++)
            {
                for(int j = 0; j<timovi[i].Ekipa.dajUkupanBrojIgraca(); j++)
                {
                    for(int k = 0; k < strijelci.Count; k++)
                    {
                        if (strijelci[k].PostignutiGolovi < timovi[i].Ekipa.dajSveIgrace()[j].PostignutiGolovi)
                            strijelci[k] = timovi[i].Ekipa.dajSveIgrace()[j];
                    }
                }
            }
            return strijelci;
        }
        public List<Igrac> najboljiGolmani()
        {
            List<Igrac> golmani = new List<Igrac>(5);
            // Top 5 najboljih
            for(int i = 0; i < timovi.Count; i++)
            {
                for(int j = 0; j < timovi[i].Ekipa.dajUkupanBrojIgraca(); j++)
                {
                    for(int k = 0; k < golmani.Count; k++)
                    {
                        if (golmani[k].CleanSheet < timovi[i].Ekipa.dajSveIgrace()[j].CleanSheet)
                            golmani[k] = timovi[i].Ekipa.dajSveIgrace()[j];
                    }
                }
            }
            return golmani;
        }
    }
}
