using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Klub
    {
        // Atributi
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;
        Tim ekipa;
        double racun;
        StatistikaKluba statistika;

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
        public Tim Ekipa
        {
            get
            {
                return ekipa;
            }

            set
            {
                ekipa = value;
            }
        }
        public double Racun
        {
            get
            {
                return racun;
            }

            set
            {
                racun = value;
            }
        }
        public StatistikaKluba Statistika
        {
            get
            {
                return statistika;
            }

            set
            {
                statistika = value;
            }
        }
        

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
