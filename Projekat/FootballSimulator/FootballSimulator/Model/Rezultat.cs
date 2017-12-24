using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    public class Rezultat
    {
        // Atributi
        private String id;
        int domaci, gosti;
        bool odigrana;

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

        public bool Odigrana { get => odigrana; set => odigrana = value; }


        // Konstruktori
        public Rezultat()
        {
            domaci = gosti = 0;
        }
        public Rezultat(int domaci, int gosti)
        {
            this.Domaci = domaci;
            this.Gosti = gosti;
        }

        public Rezultat(int domaci, int gosti, bool odigrana)
        {
            if (domaci < 0 || gosti < 0)
                throw new ArgumentException("Rezultat ne smije sadrzavati negativne brojeve");
            this.Domaci = domaci;
            this.Gosti = gosti;
            this.odigrana = odigrana;
        }

        public bool JeLiNerjeseno()
        {
            if (!odigrana)
                throw new Exception("Utakmica nije odigrana");
            return domaci == gosti;
        }
       

        // Metode
        public override string ToString()
        {
            return Convert.ToString(domaci) + " : " + Convert.ToString(gosti);
        }
    }
}
