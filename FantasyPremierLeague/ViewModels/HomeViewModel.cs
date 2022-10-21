using FantasyPremierLeague.Models.bootstrap_static.elements;
using FantasyPremierLeague.Models.bootstrap_static.events;
using FantasyPremierLeague.Models.bootstrap_static.events.lists_and_objects;
using FantasyPremierLeague.Models.dream_team.teams;
using FantasyPremierLeague.Models.entry_event_picks;
using FantasyPremierLeague.Models.entry_event_picks.picks;
using FantasyPremierLeague.Models.event_status;
using FantasyPremierLeague.Models.event_status.statuses;
using System.Collections;
using System.Collections.Generic;

namespace FantasyPremierLeague.ViewModels
{
    public class HomeViewModel
    {
        public EventStatusRootobject event_status_rootobject { get; set; }
        public Dictionary<Status, Hashtable> event_status { get; set; }
        public Dictionary<Event, Hashtable> event_info { get; set; }
        public Dictionary<Pick, Hashtable> my_team { get; set; }
        public int my_team_total_points { get; set; }
        public int my_bench_total_points { get; set; }
        public Dictionary<Team, Hashtable> team_of_the_week { get; set; }
        public int team_of_the_week_total_points { get; set; }
        public Dictionary<Element, Hashtable> top_transfers_in { get; set; }
        public Dictionary<Element, Hashtable> top_transfers_out { get; set; }
    }
}
