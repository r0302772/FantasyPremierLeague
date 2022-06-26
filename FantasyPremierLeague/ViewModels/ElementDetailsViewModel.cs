using FantasyPremierLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.ViewModels
{
    public class ElementDetailsViewModel
    {
        public List<History> history { get; set; }
        public Element element { get; set; }
        public Element_Type element_type { get; set; }

        public double CostDifference { get; set; }
    }
}
