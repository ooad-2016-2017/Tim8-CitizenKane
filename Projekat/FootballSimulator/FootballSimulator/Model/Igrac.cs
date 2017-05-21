using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Igrac
    {
        // Osnovni atributi
        String ime;
        int godine;
        double cijena;
        // Promjenjivi atributi - forma
        int stamina, gk, def, mid, att, postignutiGolovi, cleanSheet;
        bool suspendovan;

        // Properties
        public string Ime { get => ime; set => ime = value; }
        public int Godine { get => godine; set => godine = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public int Stamina { get => stamina; set => stamina = value; }
        public int GK { get => gk; set => gk = value; }
        public int DEF { get => def; set => def = value; }
        public int MID { get => mid; set => mid = value; }
        public int ATT { get => att; set => att = value; }
        public int PostignutiGolovi { get => postignutiGolovi; set => postignutiGolovi = value; }
        public int CleanSheet { get => cleanSheet; set => cleanSheet = value; }
        public bool Suspendovan { get => suspendovan; set => suspendovan = value; }

        // Konstruktori
        public Igrac() // default
        {
            this.ime = "";
            this.godine = 0;
            this.cijena = 0;
            this.stamina = 0;
            this.gk = 0;
            this.def = 0;
            this.mid = 0;
            this.att = 0;
            this.postignutiGolovi = 0;
            this.cleanSheet = 0;
            this.suspendovan = false;
        }
        public Igrac(Igrac i)
        {
            this.ime = i.ime;
            this.godine = i.godine;
            this.cijena = i.cijena;
            this.stamina = i.stamina;
            GK = i.GK;
            DEF = i.DEF;
            MID = i.MID;
            ATT = i.ATT;
            this.postignutiGolovi = i.postignutiGolovi;
            this.cleanSheet = i.cleanSheet;
            this.suspendovan = i.suspendovan;
        }
        public Igrac(string ime, int godine, double cijena, int umor, int gK, int dEF, int mID, int aTT, int postignutiGolovi, int cleanSheet, bool suspendovan) // svi atributi koje posjeduje
        {
            this.ime = ime;
            this.godine = godine;
            this.cijena = cijena;
            this.stamina = umor;
            GK = gK;
            DEF = dEF;
            MID = mID;
            ATT = aTT;
            this.postignutiGolovi = postignutiGolovi;
            this.cleanSheet = cleanSheet;
            this.suspendovan = suspendovan;
        }
        public Igrac(string ime, int godine, double cijena, int gK, int dEF, int mID, int aTT) // kreacija igraca prije pocetka sezone (bez umora, golova, suspenzija)
        {
            this.ime = ime;
            this.godine = godine;
            this.cijena = cijena;
            GK = gK;
            DEF = dEF;
            MID = mID;
            ATT = aTT;
            this.postignutiGolovi = 0;
            this.cleanSheet = 0;
            this.suspendovan = false;
        }

        // Metode
        public void povecajCijenu(int procenat)
        {
            cijena = cijena * (procenat)/ (100.0);
        }
        public void postaviUmor(int vrijednost) // metoda kojom regulisemo umor (recimo za odmorenog igraca)
        {
            stamina = vrijednost;
        }
        public void dodajUmor(int vrijednost) // metoda kojom bi nakon utakmice dodali odredjenu vrijednost umora bez previse racunanja
        {
            stamina -= vrijednost;
        }
    }
}
