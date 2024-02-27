using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("SeasonId")]
        public Season Season { get; set; }

        [ForeignKey("LeagueId")]
        public League League { get; set; }

        [ForeignKey("HomeTeamId")]
        public Team HomeTeam { get; set; }

        [ForeignKey("AwayTeamId")]
        public Team AwayTeam { get; set; }
        // Add other properties as needed
    }
}
