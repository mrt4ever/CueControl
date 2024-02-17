using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class PlayerStanding
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int LeagueId { get; set; }
        public int SeasonId { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int TotalPlayed { get; set; }
        public int Points { get; set; }
        // Add other properties as needed
    }
}
