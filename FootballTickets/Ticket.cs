using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTickets
{
    class Ticket
    {
        [Key]
        public int id_ticket { get; set; }
        private int id_matches { get; set; }
        private int price { get; set; }

        public int Id_matches
        {
            get { return id_matches; }
            set { id_matches = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
