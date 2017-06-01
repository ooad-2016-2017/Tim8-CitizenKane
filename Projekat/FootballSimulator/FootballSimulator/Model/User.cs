using FootballSimulator.ExternalDevices.Arduino;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulator.Model
{
    class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private String id;

        public static User aktivniKorisnik;
        public static Arduino arduino = null;

        private string userName;

        public string Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
    }
}
