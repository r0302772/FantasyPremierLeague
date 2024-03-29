﻿using FantasyPremierLeague.Models.entry_history.chips;
using FantasyPremierLeague.Models.entry_history.current_season;
using FantasyPremierLeague.Models.entry_history.past_seasons;
using System.Collections.Generic;

namespace FantasyPremierLeague.Models.entry_history
{
    //Endpoint path: entry/{manager_id}/history/

    public class EntryHistoryRootobject
    {
        public List<CurrentSeason> current { get; set; }
        public List<PastSeason> past { get; set; }
        public List<Chip> chips { get; set; }
    }
}
