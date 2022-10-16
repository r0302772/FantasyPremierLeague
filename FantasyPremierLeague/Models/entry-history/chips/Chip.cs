using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.entry_history.chips
{
    public class Chip
    {
        public string name { get; set; }
        public DateTime time { get; set; }
        public int _event { get; set; }
    }
}
