using FootballSimulator.Model.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Igrac
    {
        // Osnovni atributi
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;
        String ime;
        int godine;
        double cijena;
        // Promjenjivi atributi - forma
        int stamina, gk, def, mid, att, postignutiGolovi, cleanSheet;
        bool suspendovan;

        //Utakmice na kojima je dao gol
        private List<UtakmicaIgrac> daoGol;

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
        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }
        public int Godine
        {
            get
            {
                return godine;
            }

            set
            {
                godine = value;
            }
        }
        public double Cijena
        {
            get
            {
                return cijena;
            }

            set
            {
                cijena = value;
            }
        }
        public int Stamina
        {
            get
            {
                return stamina;
            }

            set
            {
                stamina = value;
            }
        }
        public int Gk
        {
            get
            {
                return gk;
            }

            set
            {
                gk = value;
            }
        }
        public int Def
        {
            get
            {
                return def;
            }

            set
            {
                def = value;
            }
        }
        public int Mid
        {
            get
            {
                return mid;
            }

            set
            {
                mid = value;
            }
        }
        public int Att
        {
            get
            {
                return att;
            }

            set
            {
                att = value;
            }
        }
        public int PostignutiGolovi
        {
            get
            {
                return postignutiGolovi;
            }

            set
            {
                postignutiGolovi = value;
            }
        }
        public int CleanSheet
        {
            get
            {
                return cleanSheet;
            }

            set
            {
                cleanSheet = value;
            }
        }
        public bool Suspendovan
        {
            get
            {
                return suspendovan;
            }

            set
            {
                suspendovan = value;
            }
        }

        internal List<UtakmicaIgrac> DaoGol { get => daoGol; set => daoGol = value; }


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
            Gk = i.Gk;
            Def = i.Def;
            Mid = i.Mid;
            Att = i.Att;
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
            Gk = gK;
            Def = dEF;
            Mid = mID;
            Att = aTT;
            this.postignutiGolovi = postignutiGolovi;
            this.cleanSheet = cleanSheet;
            this.suspendovan = suspendovan;
        }
        public Igrac(string ime, int godine, double cijena, int gK, int dEF, int mID, int aTT) // kreacija igraca prije pocetka sezone (bez umora, golova, suspenzija)
        {
            this.ime = ime;
            this.godine = godine;
            this.cijena = cijena;
            Gk = gK;
            Def = dEF;
            Mid = mID;
            Att = aTT;
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
