using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Kolo
    {
        // Atributi
        List<Utakmica> utakmice;
        bool odigrano;

        // Properties
        public List<Utakmica> Utakmice { get => utakmice; set => utakmice = value; }
        public bool Odigrano { get => odigrano; set => odigrano = value; }

        // Konstruktori
        public Kolo()
        {
            Utakmice = new List<Utakmica>();
            Odigrano = false;
        }
        public Kolo(List<Utakmica> utakmice)
        {
            this.Utakmice = utakmice;
            Odigrano = false;
        }
        public Kolo(List<Utakmica> utakmice, bool odigrano)
        {
            this.Utakmice = utakmice;
            this.Odigrano = odigrano;
        }

        // Metode
        public int odigraj()
        {
            if (!Odigrano) {
                foreach (Utakmica u in Utakmice)
                {
                    u.odigraj();
                }
                Odigrano = true;
            }
            else
            {
                throw new Exception("Kolo je vec odigrano");
            }

            return Utakmice.Count;
        }
        public List<String> dajRezimeKola()
        {
            List<String> lista = new List<string>();
            foreach (Utakmica u in Utakmice)
                lista.Add(u.ToString());
            return lista;
        }


    }
}
