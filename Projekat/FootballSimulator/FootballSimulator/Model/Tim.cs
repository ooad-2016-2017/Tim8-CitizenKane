using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    public class Tim
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

        public List<Igrac> Sastav { get => sastav; set => sastav = value; }



        // Konstruktori
        public Tim()
        {
            this.Naziv = "";
            this.Formacija = "4-4-2";
            this.Kapiten = null;
            dummy = new Igrac("", 0, 0, 0, 0, 0, 0);
        }
        public Tim(string naziv, List<Igrac> sastav, string formacija, Igrac kapiten)
        {
            this.Naziv = naziv;
            this.Sastav = sastav;
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
            return Sastav.Where(i => i != dummy).Count();
        }

        public void obrisiIgraca(Igrac igrac)
        {

            for (int i = 0; i < 11; i++)
            {
                if (Sastav[i].Id == igrac.Id)
                {
                    Sastav[i] = dummy;
                    return;
                }
            }

            for (int i = 11; i < 17; i++)
            {
                if (Sastav[i].Id == igrac.Id)
                {
                    Sastav[i] = dummy;
                    return;
                }
            }

            for (int i = 17; i < 25; i++)
            {
                if (Sastav[i].Id == igrac.Id)
                {
                    Sastav[i] = dummy;
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
            int trenutnaPozicija = Sastav.IndexOf(i);
            Sastav[trenutnaPozicija] = pronadjiIgraca(pozicija);
            Sastav[pozicija] = i;
        }
        public Igrac pronadjiIgraca(int pozicija)
        {
            return Sastav[pozicija];
        }
        public List<Igrac> dajSveIgrace()
        {
            return Sastav;
        }

        public override string ToString()
        {
            return naziv;
        }

    }
}
