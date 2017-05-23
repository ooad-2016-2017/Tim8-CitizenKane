using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Sezona
    {
        // Atributi
        private String id;
        List<Klub> timovi;
        List<Kolo> kola;
        int mojKlub; // indeks kluba u listi klubova (trebalo bi namjestiti da je 0)
        int trenutnoKolo;

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


        // Konstruktori
        public Sezona()
        {
            this.timovi = new List<Klub>();
            this.kola = new List<Kolo>();
            this.mojKlub = 0;
            trenutnoKolo = 1; // kolo koje ce se sljedece odigrati
        }
        public Sezona(List<Klub> timovi, List<Kolo> kola, int mojKlub, int trenutnoKolo)
        {
            this.timovi = timovi;
            this.kola = kola;
            this.mojKlub = mojKlub;
            this.trenutnoKolo = trenutnoKolo;
        }
        public Sezona(Klub mojTim, List<Klub> ostaliTimovi)
        {
            this.timovi = ostaliTimovi;
            this.kola = generisiKola();
            this.mojKlub = ostaliTimovi.FindIndex((x) => x.Id == mojTim.Id);
            this.trenutnoKolo = 0;
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
        public List<Igrac> najboljiStrijelci()
        {
            List<Igrac> strijelci = new List<Igrac>();
            // dodati algoritam za racunanje najboljih strijelaca
            return strijelci;
        }
        public List<Igrac> najboljiGolmani()
        {
            List<Igrac> golmani = new List<Igrac>();
            // dodati algoritam za racunanje najboljih golmana
            return golmani;
        }
        public List<Kolo> generisiKola()
        {
            // dodati algoritam za generisanje kola
            return new List<Kolo>(); // privremeno da kompajlira :(

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

    }
}
