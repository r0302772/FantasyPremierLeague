using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.event_live.elements
{
    public class Element
    {
        public int id { get; set; }
        public Stats stats { get; set; }
        public List<Explain> explain { get; set; }
    }
}
