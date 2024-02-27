using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class TeamPlayer
    {
        public int Id { get; set; }
        public int TeamId { get; set; } // Reference to the team the player belongs to
        public int PlayerId { get; set; } // Reference to the team the player belongs to

        public Team Team { get; set; }
        public Player Player { get; set; }
    }
}
