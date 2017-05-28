using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model.Database
{

    //many to many za utakmica - igrac, tj strijelce na utakmici
    class UtakmicaIgrac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;

        private Utakmica utakmica;

        private Igrac igrac;

        public string Id { get => id; set => id = value; }
        internal Utakmica Utakmica { get => utakmica; set => utakmica = value; }
        internal Igrac Igrac { get => igrac; set => igrac = value; }
    }
}
