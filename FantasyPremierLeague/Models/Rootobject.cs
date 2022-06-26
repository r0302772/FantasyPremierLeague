using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FantasyPremierLeague.Models
{
    public class Rootobject
    {
        //Endpoint path: bootstrap-static/
        public List<Event> events { get; set; } //Basic information of every Gameweek
        public List<Team> teams { get; set; } //Basic information of current Premier League clubs.
        public List<Element> elements { get; set; } //Information of all Premier League players
        public List<Element_Type> element_types { get; set; } //Basic information about player’s position

        //Endpoint path: element-summary/{element_id}/
        public List<Fixture> fixtures { get; set; } //A list of {element_id} remaining fixtures of the season.
        public List<History> history { get; set; } //A list of {element_id} previous fixtures and its match stats.

        //Endpoint path: dream-team/{event_id}/
        public Top_Element_Info top_player { get; set; } //The highest scoring player of the {event_id} gameweek
        public List<Dreamteam> team { get; set; } //A list of the best players of the {event_id} gameweek

        //Not important
        //public Element_Stats[] element_stats { get; set; }
        //public int total_players { get; set; }
        //public Phase[] phases { get; set; }
        //public Game_Settings game_settings { get; set; }
    }


    /*public class Game_Settings
    {
        public int league_join_private_max { get; set; }
        public int league_join_public_max { get; set; }
        public int league_max_size_public_classic { get; set; }
        public int league_max_size_public_h2h { get; set; }
        public int league_max_size_private_h2h { get; set; }
        public int league_max_ko_rounds_private_h2h { get; set; }
        public string league_prefix_public { get; set; }
        public int league_points_h2h_win { get; set; }
        public int league_points_h2h_lose { get; set; }
        public int league_points_h2h_draw { get; set; }
        public bool league_ko_first_instead_of_random { get; set; }
        public object cup_start_event_id { get; set; }
        public object cup_stop_event_id { get; set; }
        public object cup_qualifying_method { get; set; }
        public object cup_type { get; set; }
        public int squad_squadplay { get; set; }
        public int squad_squadsize { get; set; }
        public int squad_team_limit { get; set; }
        public int squad_total_spend { get; set; }
        public int ui_currency_multiplier { get; set; }
        public bool ui_use_special_shirts { get; set; }
        public object[] ui_special_shirt_exclusions { get; set; }
        public int stats_form_days { get; set; }
        public bool sys_vice_captain_enabled { get; set; }
        public int transfers_cap { get; set; }
        public float transfers_sell_on_fee { get; set; }
        public string[] league_h2h_tiebreak_stats { get; set; }
        public string timezone { get; set; }
    }
    public class Chip_Plays
    {
        public string chip_name { get; set; }
        public int num_played { get; set; }
    }

    public class Phase
    {
        public int id { get; set; }
        public string name { get; set; }
        public int start_event { get; set; }
        public int stop_event { get; set; }
    }
    public class Element_Stats
    {
        public string label { get; set; }
        public string name { get; set; }
    }*/
}
