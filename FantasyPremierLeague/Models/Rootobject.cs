using System;
using System.Collections.Generic;

namespace FantasyPremierLeague.Models
{
    public class Rootobject
    {
        //Endpoint path: bootstrap-static/

        //Basic information of every Gameweek
        public List<Event> events { get; set; }
        //The game settings and rules.
        public Game_Settings game_settings { get; set; }
        //Phases of FPL season.
        public List<Phase> phases { get; set; }
        //Basic information of current Premier League clubs.
        public List<Team> teams { get; set; }
        //Information of all Premier League players (bootstrap-static/ endpoint)
        //A list of players’ information in that specific Gameweek (event/{event_id}/live/ endpoint)
        public List<Element> elements { get; set; }
        //Basic information about player’s position
        public List<Element_Type> element_types { get; set; }


        //Endpoint path: element-summary/{element_id}/

        //A list of {element_id} remaining fixtures of the season.
        public List<Fixture> fixtures { get; set; }
        //A list of {element_id} previous fixtures and its match stats.
        public List<History> history { get; set; }


        //Endpoint path: dream-team/{event_id}/

        //The highest scoring player of the {event_id} gameweek
        public Top_Element_Info top_player { get; set; }
        //A list of the best players of the {event_id} gameweek
        public List<Dreamteam> team { get; set; }


        //Endpoint path: leagues-classic/{league_id}/standings

        public New_Entry new_entries { get; set; }
        public DateTime last_updated_data { get; set; }
        public League league { get; set; }
        public Standings standings { get; set; }


        //Not important yet
        //public int total_players { get; set; }
    }
}
