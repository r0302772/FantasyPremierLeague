using System.ComponentModel.DataAnnotations;

namespace FantasyPremierLeague.Models
{
    public class Result
    {
        public int id { get; set; }
        [Display(Name = "Gameweek Total")]
        public int event_total { get; set; } //refers to the event points
        [Display(Name = "Manager")]
        public string player_name { get; set; }
        [Display(Name = "Rank")]
        public int rank { get; set; }
        [Display(Name = "Last Rank")]
        public int last_rank { get; set; }
        [Display(Name = "Rank Sort")]
        public int rank_sort { get; set; }
        [Display(Name = "Total Points")]
        public int total { get; set; } //refers to the total points
        [Display(Name = "Manager ID")]
        public int entry { get; set; } //refers to the manager id
        [Display(Name = "Team")]
        public string entry_name { get; set; } //refers to the fantasyteam name

        //extra props
        [Display(Name = "Point Difference First Place")]
        public int point_difference_first_place { get; set; }
        [Display(Name = "Point Difference Last Place")]
        public int point_difference_last_place { get; set; }
        [Display(Name = "Point Difference Place Up")]
        public int point_difference_place_up { get; set; }
        [Display(Name = "Point Difference Place Down")]
        public int point_difference_place_down { get; set; }
    }
}
