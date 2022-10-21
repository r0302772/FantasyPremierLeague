using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.entry_event_picks.picks
{
    public class Pick
    {
        public int element { get; set; }
        public int position { get; set; }
        public int multiplier { get; set; }
        public bool is_captain { get; set; }
        public bool is_vice_captain { get; set; }
    }
}
