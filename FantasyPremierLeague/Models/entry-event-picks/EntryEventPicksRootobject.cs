using FantasyPremierLeague.Models.entry_event_picks.automatic_subs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.entry_event_picks
{
    //Endpoint path: entry/{manager_id}/event/{event_id}/picks/
    public class EntryEventPicksRootobject
    {
        public string active_chip { get; set; }
        public List<Automatic_Sub> automatic_subs { get; set; }
        public Entry_History entry_history { get; set; }
        public List<Pick> picks { get; set; }
    }
}
