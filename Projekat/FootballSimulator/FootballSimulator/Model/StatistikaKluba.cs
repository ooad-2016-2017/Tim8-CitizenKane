using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class StatistikaKluba
    {
        // Atributi
        private String id;
        int bodovi, postignutiGolovi, primljeniGolovi, pobjede, remi, porazi;

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

        public int Bodovi
        {
            get
            {
                return bodovi;
            }

            set
            {
                bodovi = value;
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

        public int PrimljeniGolovi
        {
            get
            {
                return primljeniGolovi;
            }

            set
            {
                primljeniGolovi = value;
            }
        }

        public int Pobjede
        {
            get
            {
                return pobjede;
            }

            set
            {
                pobjede = value;
            }
        }

        public int Remi
        {
            get
            {
                return remi;
            }

            set
            {
                remi = value;
            }
        }

        public int Porazi
        {
            get
            {
                return porazi;
            }

            set
            {
                porazi = value;
            }
        }

        // Konstruktori
        public StatistikaKluba()
        {
            this.bodovi = 0;
            this.postignutiGolovi = 0;
            this.primljeniGolovi = 0;
            this.pobjede = 0;
            this.remi = 0;
            this.porazi = 0;
        }
        public StatistikaKluba(int bodovi, int postignutiGolovi, int primljeniGolovi, int pobjede, int remi, int porazi)
        {
            this.bodovi = bodovi;
            this.postignutiGolovi = postignutiGolovi;
            this.primljeniGolovi = primljeniGolovi;
            this.pobjede = pobjede;
            this.remi = remi;
            this.porazi = porazi;
        }

        // Metode
        public int dajGolRazliku()
        {
            return postignutiGolovi - primljeniGolovi;
        }
        public int dajBrojOdigranih()
        {
            return pobjede + remi + porazi;
        }
        public void dodajOdigranu(Utakmica u)
        {
            // dodati kod za dodavanje odigrane utakmice
        }
    }
}
