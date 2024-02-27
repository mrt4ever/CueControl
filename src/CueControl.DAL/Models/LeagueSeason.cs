using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class LeagueSeason
    {
        public int Id { get; set; }
        public int LeagueId { get; set; }
        public int SeasonId { get; set; }

        public League League { get; set; }
        public Season Season { get; set; }  

    }
}
