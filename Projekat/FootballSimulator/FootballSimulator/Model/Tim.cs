using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class Tim
    {
        // Atributi
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;
        String naziv;
        List<Igrac> pocetniSastav;
        List<Igrac> klupaSastav;
        List<Igrac> rezerveSastav;
        String formacija;
        Igrac kapiten;
        static Igrac dummy;

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        internal List<Igrac> PocetniSastav
        {
            get
            {
                return pocetniSastav;
            }

            set
            {
                pocetniSastav = value;
            }
        }

        internal List<Igrac> KlupaSastav
        {
            get
            {
                return klupaSastav;
            }

            set
            {
                klupaSastav = value;
            }
        }

        internal List<Igrac> RezerveSastav
        {
            get
            {
                return rezerveSastav;
            }

            set
            {
                rezerveSastav = value;
            }
        }

        public string Formacija
        {
            get
            {
                return formacija;
            }

            set
            {
                formacija = value;
            }
        }

        internal Igrac Kapiten
        {
            get
            {
                return kapiten;
            }

            set
            {
                kapiten = value;
            }
        }

        internal static Igrac Dummy
        {
            get
            {
                return dummy;
            }

            set
            {
                dummy = value;
            }
        }

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



        // Konstruktori
        public Tim()
        {
            this.Naziv = "";
            this.PocetniSastav = new List<Igrac>();
            this.KlupaSastav = new List<Igrac>();
            this.RezerveSastav = new List<Igrac>();
            this.Formacija = "4-4-2";
            this.Kapiten = null;
            dummy = new Igrac("", 0, 0, 0, 0, 0, 0);
        }
        public Tim(string naziv, List<Igrac> pocetniSastav, List<Igrac> klupaSastav, List<Igrac> rezerveSastav, string formacija, Igrac kapiten)
        {
            this.Naziv = naziv;
            this.PocetniSastav = pocetniSastav;
            this.KlupaSastav = klupaSastav;
            this.RezerveSastav = rezerveSastav;
            this.Formacija = formacija;
            this.Kapiten = kapiten;
            dummy = new Igrac("", 0, 0, 0, 0, 0, 0);
        }

        // Metode
        public void dodajIgraca(Igrac i)
        {
            if (pocetniSastav.Count < 11)
                pocetniSastav.Add(i);
            else if (klupaSastav.Count < 6)
                klupaSastav.Add(i);
            else if (rezerveSastav.Count < 10)
                rezerveSastav.Add(i);
            else
            {
                throw new Exception("Tim ima maksimalan broj igraca");
            }
        }

        public int dajUkupanBrojIgraca()
        {
            return pocetniSastav.Count + rezerveSastav.Count + klupaSastav.Count;
        }

        public void obrisiIgraca(Igrac igrac)
        {
            if (pocetniSastav.Count != 0)
            {
                for (int i = 0; i < pocetniSastav.Count; i++)
                {
                    if (pocetniSastav[i].Ime == igrac.Ime)
                    {
                        pocetniSastav[i] = dummy;
                        return;
                    }
                }
            }
            if (klupaSastav.Count != 0)
            {
                for (int i = 0; i < klupaSastav.Count; i++)
                {
                    if (klupaSastav[i].Ime == igrac.Ime)
                    {
                        if (rezerveSastav.Count != 0)
                        {
                            klupaSastav[i] = rezerveSastav[0];
                            rezerveSastav.RemoveAt(0);
                        }
                        else
                            klupaSastav[i] = dummy;
                        return;
                    }
                }
            }
            if (rezerveSastav.Count != 0)
            {
                for (int i = 0; i < rezerveSastav.Count; i++)
                {
                    if (rezerveSastav[i].Ime == igrac.Ime)
                    {
                        rezerveSastav.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        public void promjeniFormaciju(String novaFormacija)
        {
            formacija = novaFormacija;
        }
        // pozicije igraca: 0 - golman, 10 - posljednji u prvoj postavi
        // 11 - 16 klupa
        // 17 - 27 rezerve
        public void promjeniPoziciju(Igrac i, int pozicija)
        {
                rezerveSastav.Add(pronadjiIgraca(pozicija));
                //pronadjiIgraca(pozicija) = i;
        }
        public Igrac pronadjiIgraca(int pozicija)
        {
            Igrac i;
            if (pozicija < 11)
            { 
                i = pocetniSastav[pozicija];
            }
            else if (pozicija < 17)
                i = klupaSastav[pozicija - 10];
            else
                i = rezerveSastav[pozicija - 16];
            return i;
        }
            
    }
}
