using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.ViewModels
{
    public class TeamDetailsViewModel
    {
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Short Name")]
        public string short_name { get; set; }
        [Display(Name = "Postition")]
        public int position { get; set; }
        [Display(Name = "Wins")]
        public int win { get; set; }
        [Display(Name = "Draws")]
        public int draw { get; set; }
        [Display(Name = "Losses")]
        public int loss { get; set; }
        //[Display(Name = "Point Total")]
        //public int total_points
        //{
        //    get
        //    {
        //        return win * 3 + draw;
        //    }
        //}

        [Display(Name = "Overall Strength")]
        public int strength { get; set; }
        [Display(Name = "Overall Strength Home")]
        public int strength_overall_home { get; set; }
        [Display(Name = "Overall Strength Away")]
        public int strength_overall_away { get; set; }
        [Display(Name = "Strength Attack Home")]
        public int strength_attack_home { get; set; }
        [Display(Name = "Strength Attack Away")]
        public int strength_attack_away { get; set; }
        [Display(Name = "Strength Defence Away")]
        public int strength_defence_home { get; set; }
        [Display(Name = "Strength Defence Away")]
        public int strength_defence_away { get; set; }
        [Display(Name = "Unavailable")]
        public bool unavailable { get; set; }
    }
}
