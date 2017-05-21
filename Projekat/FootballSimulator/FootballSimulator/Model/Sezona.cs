﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Sezona
    {
        // Atributi
        List<Klub> timovi;
        List<Kolo> kola;
        int mojKlub; // indeks kluba u listi klubova (trebalo bi namjestiti da je 0)
        int trenutnoKolo;

        // Properties
        public int TrenutnoKolo { get => trenutnoKolo; set => trenutnoKolo = value; }
        public List<Klub> Timovi { get => timovi; set => timovi = value; }
        public List<Kolo> Kola { get => kola; set => kola = value; }
        public int MojKlub { get => mojKlub; set => mojKlub = value; }

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
        public void generisiKola()
        {
            // dodati algoritam za generisanje kola
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
