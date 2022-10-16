using FantasyPremierLeague.Models.element_summary.histories_past;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.element_summary
{
    //Endpoint path: element-summary/{element_id}/
    public class ElementSummaryRootobject
    {
        //A list of {element_id} remaining fixtures of the season.
        public List<Fixture> fixtures { get; set; }
        //A list of {element_id} previous fixtures and its match stats.
        public List<History> history { get; set; }
        public List<History_Past> history_past { get; set; }
    }
}
