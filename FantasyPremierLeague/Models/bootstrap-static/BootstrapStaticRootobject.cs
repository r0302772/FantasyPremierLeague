using FantasyPremierLeague.Models.bootstrap_static.element_types;
using FantasyPremierLeague.Models.bootstrap_static.elements;
using FantasyPremierLeague.Models.bootstrap_static.events;
using FantasyPremierLeague.Models.bootstrap_static.game_settings;
using FantasyPremierLeague.Models.bootstrap_static.phases;
using FantasyPremierLeague.Models.bootstrap_static.teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.bootstrap_static
{        
    //Endpoint path: bootstrap-static/
    public class BootstrapStaticRootobject
    {
        //Basic information of every Gameweek
        public List<Event> events { get; set; }
        //The game settings and rules.
        public Game_Settings game_settings { get; set; }
        //Phases of FPL season.
        public List<Phase> phases { get; set; }
        //Basic information of current Premier League clubs.
        public List<Team> teams { get; set; }
        //Information of all Premier League players (bootstrap-static/ endpoint)
        public int total_players { get; set; }
        public List<Element> elements { get; set; }
        //Label of player statistics and their abbreviation
        public List<Element_Stat> element_stats { get; set; }

        //Basic information about player’s position
        public List<Element_Type> element_types { get; set; }
    }
}
