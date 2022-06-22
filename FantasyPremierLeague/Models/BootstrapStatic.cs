using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models
{
    public class BootstrapStatic
    {
        public Fixture[] events { get; set; }
        public Team[] teams { get; set; }
        public Player[] elements { get; set; }
        public Position[] element_types { get; set; }
    }
}
