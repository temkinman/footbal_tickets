using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTickets
{
    class Match
    {
        [Key]
        public int id_match { get; set; }
        private int id_team_1 { get; set; }
        private int id_team_2 { get; set; }
        private int id_stadium { get; set; }
        private string date_event { get; set; }

        public int Id_team_1
        {
            get { return id_team_1; }
            set { id_team_1 = value; }
        }

        public int Id_team_2
        {
            get { return id_team_2; }
            set { id_team_2 = value; }
        }

        public int Id_stadium
        {
            get { return id_stadium; }
            set { id_stadium = value; }
        }

        public string Date_event
        {
            get { return date_event; }
            set { date_event = value; }
        }
    }
}
