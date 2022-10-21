using FantasyPremierLeague.Models.leagues_classic_standings.standings.list_and_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.leagues_classic_standings.standings
{
    public class Standing
    {
        public bool has_next { get; set; }
        public int page { get; set; }
        public List<Result> results { get; set; }
    }
}
