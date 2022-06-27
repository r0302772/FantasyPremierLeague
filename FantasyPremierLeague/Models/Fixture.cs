using System;
using System.ComponentModel.DataAnnotations;

namespace FantasyPremierLeague.Models
{
    //Endpoint path: fixtures/
    //Endpoint path: element-summary/{element_id}/
    //A list of player’s remaining fixtures of the season.
    public class Fixture
    {
        public int code { get; set; }
        [Display(Name = "Gameweek")]
        public int Event { get; set; } //refers to the id in Event class
        [Display(Name = "Finished")]
        public bool finished { get; set; }
        public bool finished_provisional { get; set; }
        public int id { get; set; }
        [Display(Name = "Kickoff Time")]
        public DateTime kickoff_time { get; set; }
        [Display(Name = "Minutes")]
        public int minutes { get; set; }
        public bool provisional_start_time { get; set; }
        public bool started { get; set; }
        [Display(Name = "Away")]
        public int team_a { get; set; } //refers to the id in Team class
        [Display(Name = "Score")]
        public int team_a_score { get; set; }
        [Display(Name = "Home")]
        public int team_h { get; set; } //refers to the id in Team class
        [Display(Name = "Score")]
        public int team_h_score { get; set; }
        //public Stat[] stats { get; set; } //from fixtures endpoint
        [Display(Name = "FDR")]
        public int team_h_difficulty { get; set; } //FDR value calculated by FPL
        [Display(Name = "FDR")]
        public int team_a_difficulty { get; set; } //FDR value calculated by FPL
        public int pulse_id { get; set; }

        //Endpoint path: element-summary/{element_id}/
        [Display(Name = "Gameweek")]
        public string event_name { get; set; }
        public bool is_home { get; set; }
        [Display(Name = "FDR")]
        public int difficulty { get; set; } //FDR value calculated by FPL

        //navigatieproperties
        //public Team team { get; set; }

        //extra props
        public string team_h_name { get; set; }
        public string team_a_name { get; set; }
        [Display(Name = "Predicted Winner")]
        public string predicted_winner { get; set; }
        [Display(Name = "Actual Winner")]
        public string actual_winner{ get; set; }
    }
}

