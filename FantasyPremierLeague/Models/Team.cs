using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models
{
    //Basic information of current Premier League clubs.
    public class Team
    {
        public int code { get; set; }
        [Display(Name = "D")]
        public int draw { get; set; }
        [Display(Name = "Form")]
        public object form { get; set; }
        public int id { get; set; }
        [Display(Name = "L")]
        public int loss { get; set; }
        [Display(Name = "Club")]
        public string name { get; set; }
        [Display(Name = "Played")]
        public int played { get; set; }
        [Display(Name = "Points")]
        public int points { get; set; }
        [Display(Name = "Position")]
        public int position { get; set; }
        public string short_name { get; set; }
        public int strength { get; set; }
        public object team_division { get; set; }
        public bool unavailable { get; set; }
        [Display(Name = "W")]
        public int win { get; set; }
        public int strength_overall_home { get; set; }
        public int strength_overall_away { get; set; }
        public int strength_attack_home { get; set; }
        public int strength_attack_away { get; set; }
        public int strength_defence_home { get; set; }
        public int strength_defence_away { get; set; }
        public int pulse_id { get; set; }

        //extra props
        [Display(Name = "Goals For")]
        public int goals_for { get; set; }
        [Display(Name = "Goals Against")]
        public int goals_against { get; set; }
        [Display(Name = "Goal Difference")]
        public int goal_difference { get { return goals_for - goals_against; } }

        //navigationproperties
        public List<Element> Elements { get; set; }
    }
}
