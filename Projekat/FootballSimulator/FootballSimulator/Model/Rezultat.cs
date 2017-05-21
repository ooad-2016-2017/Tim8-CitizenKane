using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Rezultat
    {
        // Atributi
        private String id;
        int domaci, gosti;

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

        public int Domaci
        {
            get
            {
                return domaci;
            }

            set
            {
                domaci = value;
            }
        }

        public int Gosti
        {
            get
            {
                return gosti;
            }

            set
            {
                gosti = value;
            }
        }


        // Konstruktori
        public Rezultat(int domaci, int gosti)
        {
            this.Domaci = domaci;
            this.Gosti = gosti;
        }
        public Rezultat()
        {
            domaci = gosti = 0;
        }

        // Metode
        public override string ToString()
        {
            return Convert.ToString(domaci) + " : " + Convert.ToString(gosti);
        }
    }
}
