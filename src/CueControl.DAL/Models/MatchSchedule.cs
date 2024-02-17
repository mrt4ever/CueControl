using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class MatchSchedule
    {
        public int Id { get; set; }
        public int SeasonId { get; set; } // Reference to the season this match belongs to
        public int LeagueId { get; set; } //Reference to which league this references
        public int Round { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public DateTime ScheduledDateTime { get; set; }
        // Add other properties as needed
    }
}
