using System;
using System.ComponentModel.DataAnnotations;

namespace FantasyPremierLeague.Models
{
    //Endpoint path: bootstrap-static/
    //Basic information of every Gameweek such as average score,
    //highest score, top scoring player, most captained, etc.
    public class Event
    {
        public int id { get; set; }
        [Display(Name = "Gameweek")]
        public string name { get; set; }
        public DateTime deadline_time { get; set; }
        public int average_entry_score { get; set; }
        public bool finished { get; set; }
        public bool data_checked { get; set; }
        public int highest_scoring_entry { get; set; }
        public int deadline_time_epoch { get; set; }
        public int deadline_time_game_offset { get; set; }
        public int highest_score { get; set; }
        public bool is_previous { get; set; }
        public bool is_current { get; set; }
        public bool is_next { get; set; }
        public bool cup_leagues_created { get; set; }
        public bool h2h_ko_matches_created { get; set; }
        //public Chip_Plays[] chip_plays { get; set; }
        public int most_selected { get; set; }
        public int most_transferred_in { get; set; }
        [Display(Name = "Most Valuable Player")]
        public int top_element { get; set; } //refers to the id in Element class
        public Top_Element_Info top_element_info { get; set; }
        public int transfers_made { get; set; }
        public int? most_captained { get; set; }
        public int? most_vice_captained { get; set; }
    }
}
