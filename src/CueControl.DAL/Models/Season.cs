using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Match> Matches { get; set; }
        public List<Standing> TeamStandings { get; set; } // Standings for teams
        public List<PlayerStanding> PlayerStandings { get; set; } // Standings for players
                                                                  // Add other properties as needed
    }
}
