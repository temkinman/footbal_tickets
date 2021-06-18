using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FootballTickets
{
    class AppContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public AppContext() : base("DefaultConnection"){}
    }
}
