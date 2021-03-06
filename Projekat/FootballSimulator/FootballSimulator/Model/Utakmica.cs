﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Utakmica
    {
        // Atributi
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;
        Tim domaci;
        Tim gosti;
        Rezultat rezultat;
        bool odigrana;
        List<Igrac> strijelci;

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
        public Tim Domaci
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
        public Tim Gosti
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
        public Rezultat Rezultat
        {
            get
            {
                return rezultat;
            }

            set
            {
                rezultat = value;
            }
        }
        public bool Odigrana
        {
            get
            {
                return odigrana;
            }

            set
            {
                odigrana = value;
            }
        }

        // Konstruktori
        public Utakmica()
        {
            this.domaci = null;
            this.gosti = null;
            this.rezultat = null;
            this.strijelci = null;
            this.odigrana = false;
        }
        public Utakmica(Tim domaci, Tim gosti)
        {
            this.domaci = domaci;
            this.gosti = gosti;
            this.rezultat = null;
            this.strijelci = null;
            this.odigrana = false;
        }
        public Utakmica(Tim domaci, Tim gosti, Rezultat rezultat, List<Igrac> strijelci)
        {
            this.domaci = domaci;
            this.gosti = gosti;
            this.rezultat = rezultat;
            this.strijelci = new List<Igrac>();
            this.odigrana = false;
        }

        // Metode
        public void odigraj()
        {
            odigrana = true;
            // generisanje rezultata, strijelaca itd.
        }
        public Tim dajPobjednika()
        {
            if(odigrana)
            {
                if (rezultat.Domaci > rezultat.Gosti)
                    return domaci;
                else
                    return gosti;
            }
            else
            {
                throw new Exception("Utakmica nije odigrana");
            }
        }
        public Tim dajPorazenog()
        {
            if(odigrana)
            {
                if (rezultat.Domaci > rezultat.Gosti)
                    return gosti;
                else
                    return domaci;
            }
            else
            {
                throw new Exception("Utakmica nije odigrana");
            }
        }
        public bool jeLiNerjesena()
        {
            if (odigrana)
            {
                if (rezultat.Domaci == rezultat.Gosti)
                    return true;
                else
                    return false;
            }
            else
            {
                throw new Exception("Utakmica nije odigrana");
            }
        }
        public override string ToString()
        {
            if (odigrana)
            {
                return domaci.Naziv + rezultat.ToString() + gosti.Naziv;
            }
            else
                return domaci.Naziv + " : " + gosti.Naziv;
        }
    } 
}
