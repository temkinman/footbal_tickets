using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTickets
{
    class Seat
    {
        [Key]
        public int id_seat { get; set; }
        private int sector { get; set; }
        private int row { get; set; }
        private int number { get; set; }

        public int Sector
        {
            get { return sector; }
            set { sector = value; }
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

    }
}
