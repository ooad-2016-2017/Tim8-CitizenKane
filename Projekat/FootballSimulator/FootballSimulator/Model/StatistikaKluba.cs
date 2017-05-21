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
        int bodovi, postignutiGolovi, primljeniGolovi, pobjede, remi, porazi;

        // Properties
        public int Bodovi { get => bodovi; set => bodovi = value; }
        public int PostignutiGolovi { get => postignutiGolovi; set => postignutiGolovi = value; }
        public int PrimljeniGolovi { get => primljeniGolovi; set => primljeniGolovi = value; }
        public int Pobjede { get => pobjede; set => pobjede = value; }
        public int Remi { get => remi; set => remi = value; }
        public int Porazi { get => porazi; set => porazi = value; }

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
