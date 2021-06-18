using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTickets
{
    class Team
    {
        [Key]
        public int id_team { get; set; }
        private string name { get; set; }
        private string country { get; set; }
        private string city { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
