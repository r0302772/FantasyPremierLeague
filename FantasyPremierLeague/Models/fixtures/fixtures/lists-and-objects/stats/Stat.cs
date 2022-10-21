using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.fixtures.fixtures.lists_and_objects.stats
{
    public class Stat
    {
        public string identifier { get; set; }
        public List<A> a { get; set; }
        public List<H> h { get; set; }
    }
}
