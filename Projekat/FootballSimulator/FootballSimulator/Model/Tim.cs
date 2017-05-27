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
        List<Igrac> sastav; 
        
        String formacija;
        Igrac kapiten;
        static Igrac dummy;

        // Properties
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
        public List<Igrac> PocetniSastav
        {
            get
            {
                return sastav.GetRange(0, 11);
            }

            set
            {
                if (value.Count != 11)
                    throw new ArgumentException("Pocetni sastav mora imati 11 igraca");
                var pocetni = sastav.GetRange(0, 11);
                pocetni = value;
            }
        }
        public List<Igrac> KlupaSastav
        {
            get
            {
                return sastav.GetRange(11, 6);
            }

            set
            {
                if (value.Count != 6)
                    throw new ArgumentException("Kluba sastav mora imati 6 igraca");
                var pocetni = sastav.GetRange(11, 6);
                pocetni = value;
            }
        }
        public List<Igrac> RezerveSastav
        {
            get
            {
                return sastav.GetRange(17, 8);
            }

            set
            {
                if (value.Count != 8)
                    throw new ArgumentException("Rezerve sastav mora imati 8 igraca");
                var pocetni = sastav.GetRange(17, 8);
                pocetni = value;
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
        public Igrac Kapiten
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
        public static Igrac Dummy
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
            //TODO: potreban update
        }

        public int dajUkupanBrojIgraca()
        {
            //Vraca broj igraca koji nisu dummy
            return sastav.Where(i => i != dummy).Count();
        }

        public void obrisiIgraca(Igrac igrac)
        {

            for (int i = 0; i < 11; i++)
            {
                if (sastav[i].Id == igrac.Id)
                {
                    sastav[i] = dummy;
                    return;
                }
            }

            for (int i = 11; i < 17; i++)
            {
                if (sastav[i].Id == igrac.Id)
                {
                    sastav[i] = dummy;
                    return;
                }
            }

            for (int i = 17; i < 25; i++)
            {
                if (sastav[i].Id == igrac.Id)
                {
                    sastav[i] = dummy;
                    return;
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
            int trenutnaPozicija = sastav.IndexOf(i);
            sastav[trenutnaPozicija] = pronadjiIgraca(pozicija);
            sastav[pozicija] = i;
        }
        public Igrac pronadjiIgraca(int pozicija)
        {
            return sastav[pozicija];
        }
        public List<Igrac> dajSveIgrace()
        {
            List<Igrac> lista = new List<Igrac>();
            lista.AddRange(pocetniSastav);
            lista.AddRange(klupaSastav);
            lista.AddRange(rezerveSastav);
            return lista;
        }
            
    }
}
