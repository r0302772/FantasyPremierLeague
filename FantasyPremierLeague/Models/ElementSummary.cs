using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models
{
    public class ElementSummary
    {
        public Fixture[] fixtures { get; set; }
        public Player[] history { get; set; }
    }
}
