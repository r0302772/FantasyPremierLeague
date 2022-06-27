﻿using System.Collections.Generic;

namespace FantasyPremierLeague.Models
{
    //Endpoint path: leagues-classic/{league_id}/standings
    public class Standings
    {
        public bool has_next { get; set; }
        public int page { get; set; }
        public List<Result> results { get; set; }
    }
}
