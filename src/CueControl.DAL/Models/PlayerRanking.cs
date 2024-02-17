using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class PlayerRanking
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int SeasonId { get; set; }
        public double StrikeRate { get; set; }
        // Add other properties as needed

    }
}
