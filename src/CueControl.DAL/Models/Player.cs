using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; } // Reference to the team the player belongs to
                                        // Add other properties as needed, e.g., age, skill level, etc.

        public int Ranking { get; set; }
    }
}
