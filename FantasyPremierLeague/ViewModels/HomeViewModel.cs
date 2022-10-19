using FantasyPremierLeague.Models.bootstrap_static.elements;
using FantasyPremierLeague.Models.bootstrap_static.events;
using FantasyPremierLeague.Models.bootstrap_static.events.lists_and_objects;
using FantasyPremierLeague.Models.dream_team.teams;
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
        public List<Top_Element_Info> player_of_the_week_list { get; set; }
        public Dictionary<Team, Hashtable> team_of_the_week { get; set; }
        public int team_of_the_week_total_points { get; set; }
        public List<Element> top_transfers_in { get; set; }
        public List<Element> top_transfers_out { get; set; }
    }
}
