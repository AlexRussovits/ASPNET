using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootBallPlayer_JPTVR18.Models
{
    public class FootballClubContext:DbContext { 
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}