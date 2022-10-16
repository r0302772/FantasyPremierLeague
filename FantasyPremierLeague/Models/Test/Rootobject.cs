using System;
using System.Collections.Generic;

namespace FantasyPremierLeague.Models
{
    public class Rootobject
    {
        //Endpoint path: dream-team/{event_id}/

        //The highest scoring player of the {event_id} gameweek
        public Top_Element_Info top_player { get; set; }
        //A list of the best players of the {event_id} gameweek
        public List<Dreamteam> team { get; set; }


        //Endpoint path: leagues-classic/{league_id}/standings

        public New_Entry new_entries { get; set; }
        public DateTime? last_updated_data { get; set; }
        public League league { get; set; }
        public Standings standings { get; set; }

        //Endpoint path: entry/{manager_id}/event/{event_id}/picks/

        public string active_chip { get; set; }
        public List<Automatic_Subs> automatic_subs { get; set; }
        public Entry_History entry_history { get; set; }
        public List<Pick> picks { get; set; }

    }
}
