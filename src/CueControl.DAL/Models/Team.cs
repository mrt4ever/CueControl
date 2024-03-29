﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueControl.DAL.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeamPlayer> TeamPlayers { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }
        // Add other properties as needed
    }
}
