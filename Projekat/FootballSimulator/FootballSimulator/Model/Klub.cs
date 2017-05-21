using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Klub
    {
        // Atributi
        Tim ekipa;
        double racun;
        StatistikaKluba statistika;

        // Properties
        public double Racun { get => racun; set => racun = value; }
        public Tim Ekipa { get => ekipa; set => ekipa = value; }
        public StatistikaKluba Statistika { get => statistika; set => statistika = value; }

        // Konstruktori
        public Klub()
        {
            this.Ekipa = new Tim();
            this.Racun = 0;
            this.Statistika = new StatistikaKluba();
        }
        public Klub(Tim ekipa, double racun)
        {
            this.Ekipa = ekipa;
            this.Racun = racun;
            this.Statistika = new StatistikaKluba();
        }
        public Klub(Tim ekipa, double racun, StatistikaKluba statistika)
        {
            this.Ekipa = ekipa;
            this.Racun = racun;
            this.Statistika = statistika;
        }


        // Metode
        public void kupiIgraca(Igrac igrac)
        {
            racun -= igrac.Cijena;
            ekipa.obrisiIgraca(igrac);
        }
        public void prodajIgraca(Igrac igrac)
        {
            racun += igrac.Cijena;
            ekipa.obrisiIgraca(igrac);
        }
    }
}
