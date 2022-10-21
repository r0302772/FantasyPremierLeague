using FantasyPremierLeague.Models.bootstrap_static.element_types;
using FantasyPremierLeague.Models.bootstrap_static.elements;
using FantasyPremierLeague.Models.element_summary.fixtures;
using FantasyPremierLeague.Models.element_summary.histories;
using System.Collections.Generic;

namespace FantasyPremierLeague.ViewModels
{
    public class ElementDetailsViewModel
    {
        public List<Fixture> element_fixtures { get; set; }
        public List<History> element_history { get; set; }
        public Element element { get; set; }
        public Element_Type element_type { get; set; }

        public double value_difference { get; set; }
        public string element_team_name { get; set; }
        public int total_minutes { get; set; }
    }
}
