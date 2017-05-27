using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Kolo
    {
        // Atributi
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;
        List<Utakmica> utakmice;
        bool odigrano;
        
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
        public List<Utakmica> Utakmice
        {
            get
            {
                return utakmice;
            }

            set
            {
                utakmice = value;
            }
        }
        public bool Odigrano
        {
            get
            {
                return odigrano;
            }

            set
            {
                odigrano = value;
            }
        }      

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
                for (int i = 0; i < utakmice.Count; i++)
                    utakmice[i].odigraj();
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
