using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class TeamStanding
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int LeagueId { get; set; }
        public int SeasonId { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Points { get; set; }
        // Add other properties as needed

        public Team Team { get; set; }
        public League League { get; set; }
        public Season Season { get; set; }  
    }
}
