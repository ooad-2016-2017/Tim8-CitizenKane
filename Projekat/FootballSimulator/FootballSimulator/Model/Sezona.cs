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
            List<Kolo> kola = new List<Kolo>();

            // Prvo kolo
            List<Utakmica> lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[9].Ekipa), new Utakmica(timovi[8].Ekipa,timovi[11].Ekipa), new Utakmica(timovi[7].Ekipa,timovi[0].Ekipa),
                new Utakmica(timovi[10].Ekipa,timovi[2].Ekipa), new Utakmica(timovi[1].Ekipa,timovi[6].Ekipa), new Utakmica(timovi[3].Ekipa,timovi[5].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Drugo kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[11].Ekipa,timovi[4].Ekipa), new Utakmica(timovi[0].Ekipa,timovi[9].Ekipa), new Utakmica(timovi[2].Ekipa,timovi[8].Ekipa),
                new Utakmica(timovi[6].Ekipa,timovi[7].Ekipa), new Utakmica(timovi[5].Ekipa,timovi[10].Ekipa), new Utakmica(timovi[3].Ekipa,timovi[1].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Trece kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[0].Ekipa), new Utakmica(timovi[11].Ekipa,timovi[2].Ekipa), new Utakmica(timovi[10].Ekipa,timovi[1].Ekipa),
                new Utakmica(timovi[8].Ekipa,timovi[5].Ekipa), new Utakmica(timovi[7].Ekipa,timovi[3].Ekipa), new Utakmica(timovi[9].Ekipa,timovi[6].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Cetvrto kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[2].Ekipa), new Utakmica(timovi[6].Ekipa,timovi[0].Ekipa), new Utakmica(timovi[11].Ekipa,timovi[5].Ekipa),
                new Utakmica(timovi[3].Ekipa,timovi[9].Ekipa), new Utakmica(timovi[1].Ekipa,timovi[8].Ekipa), new Utakmica(timovi[10].Ekipa,timovi[7].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Peto kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[6].Ekipa), new Utakmica(timovi[2].Ekipa,timovi[5].Ekipa), new Utakmica(timovi[0].Ekipa,timovi[3].Ekipa),
                new Utakmica(timovi[11].Ekipa,timovi[1].Ekipa), new Utakmica(timovi[9].Ekipa,timovi[10].Ekipa), new Utakmica(timovi[8].Ekipa,timovi[7].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Šesto kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[5].Ekipa,timovi[4].Ekipa), new Utakmica(timovi[3].Ekipa,timovi[6].Ekipa), new Utakmica(timovi[1].Ekipa,timovi[2].Ekipa),
                new Utakmica(timovi[10].Ekipa,timovi[0].Ekipa), new Utakmica(timovi[11].Ekipa,timovi[7].Ekipa), new Utakmica(timovi[8].Ekipa,timovi[9].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Sedmo kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[3].Ekipa), new Utakmica(timovi[5].Ekipa,timovi[1].Ekipa), new Utakmica(timovi[6].Ekipa,timovi[10].Ekipa),
                new Utakmica(timovi[7].Ekipa,timovi[2].Ekipa), new Utakmica(timovi[0].Ekipa,timovi[8].Ekipa), new Utakmica(timovi[11].Ekipa,timovi[9].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Osmo kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[1].Ekipa), new Utakmica(timovi[10].Ekipa,timovi[3].Ekipa), new Utakmica(timovi[7].Ekipa,timovi[5].Ekipa),
                new Utakmica(timovi[9].Ekipa,timovi[2].Ekipa), new Utakmica(timovi[8].Ekipa,timovi[6].Ekipa), new Utakmica(timovi[11].Ekipa,timovi[0].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Deveto kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[10].Ekipa), new Utakmica(timovi[8].Ekipa,timovi[3].Ekipa), new Utakmica(timovi[2].Ekipa,timovi[0].Ekipa),
                new Utakmica(timovi[5].Ekipa,timovi[9].Ekipa), new Utakmica(timovi[1].Ekipa,timovi[7].Ekipa), new Utakmica(timovi[9].Ekipa,timovi[5].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Deseto kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[7].Ekipa), new Utakmica(timovi[8].Ekipa,timovi[10].Ekipa), new Utakmica(timovi[9].Ekipa,timovi[1].Ekipa),
                new Utakmica(timovi[11].Ekipa,timovi[3].Ekipa), new Utakmica(timovi[2].Ekipa,timovi[6].Ekipa), new Utakmica(timovi[0].Ekipa,timovi[5].Ekipa),
            }; kola.Add(new Kolo(lista));
            // Jedanaesto kolo
            lista = new List<Utakmica>()
            {
                new Utakmica(timovi[4].Ekipa,timovi[8].Ekipa), new Utakmica(timovi[10].Ekipa,timovi[11].Ekipa), new Utakmica(timovi[7].Ekipa,timovi[9].Ekipa),
                new Utakmica(timovi[5].Ekipa,timovi[6].Ekipa), new Utakmica(timovi[1].Ekipa,timovi[0].Ekipa), new Utakmica(timovi[3].Ekipa,timovi[2].Ekipa),
            }; kola.Add(new Kolo(lista));


            return dupliraj(kola);
        }
        private static List<Kolo> dupliraj(List<Kolo> kola)
        {
            for(int i = 0; i < 11; i ++)
            {
                List<Utakmica> kolo = new List<Utakmica>();
                for(int j = 0; j < 6; j++)
                {
                    kolo.Add(new Utakmica(kola[i].Utakmice[j].Gosti,kola[i].Utakmice[j].Domaci));
                }
                kola.Add(new Kolo(kolo));
            }
            return kola;
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
