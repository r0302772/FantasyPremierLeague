using System;
using System.ComponentModel.DataAnnotations;

namespace FantasyPremierLeague.Models
{
    //Endpoint path: bootstrap-static/
    //Information of all Premier League players including points,
    //status, value, match stats (goals, assists, etc.), ICT index, etc.
    public class Element
    {
        [Display(Name = "Chance Of Playing Next Round")]
        public int? chance_of_playing_next_round { get; set; }
        [Display(Name = "Chance Of Playing This Round")]
        public int? chance_of_playing_this_round { get; set; }
        public int code { get; set; }
        public int cost_change_event { get; set; }
        public int cost_change_event_fall { get; set; }
        public int cost_change_start { get; set; }
        public int cost_change_start_fall { get; set; }
        [Display(Name = "Dreamteam Count")]
        public int dreamteam_count { get; set; }
        [Display(Name = "Position")]
        public int element_type { get; set; } //refers to the id in the Element_Type class
        public string ep_next { get; set; }
        public string ep_this { get; set; }
        public int event_points { get; set; }
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        [Display(Name = "Form")]
        public string form { get; set; }
        [Display(Name = "ID")]
        public int id { get; set; }
        public bool in_dreamteam { get; set; }
        [Display(Name = "News")]
        public string news { get; set; }
        [Display(Name = "News Added")]
        public DateTime? news_added { get; set; }
        [Display(Name = "Cost")]
        public int now_cost { get; set; }
        public string photo { get; set; }
        [Display(Name = "Points Per Game")]
        public string points_per_game { get; set; }
        [Display(Name = "Second Name")]
        public string second_name { get; set; }
        [Display(Name = "Selected By %")]
        public string selected_by_percent { get; set; }
        public bool special { get; set; }
        public object squad_number { get; set; }
        public string status { get; set; }
        [Display(Name = "Team")]
        public int team { get; set; } //refers to the id in the Team class
        public int team_code { get; set; }
        [Display(Name = "Total Points")]
        public int total_points { get; set; }
        [Display(Name = "Transfered In")]
        public int transfers_in { get; set; }
        public int transfers_in_event { get; set; }
        [Display(Name = "Transfered Out")]
        public int transfers_out { get; set; }
        public int transfers_out_event { get; set; }
        [Display(Name = "Value Form")]
        public string value_form { get; set; }
        [Display(Name = "Value Season")]
        public string value_season { get; set; }
        [Display(Name = "Web Name")]
        public string web_name { get; set; }
        [Display(Name = "Minutes")]
        public int minutes { get; set; }
        [Display(Name = "Goals")]
        public int goals_scored { get; set; }
        [Display(Name = "Assists")]
        public int assists { get; set; }
        [Display(Name = "Clean Sheets")]
        public int clean_sheets { get; set; }
        [Display(Name = "Goals Conceded")]
        public int goals_conceded { get; set; }
        [Display(Name = "Own Goals")]
        public int own_goals { get; set; }
        [Display(Name = "Penalties Saved")]
        public int penalties_saved { get; set; }
        [Display(Name = "Penalties Missed")]
        public int penalties_missed { get; set; }
        [Display(Name = "Yellow Cards")]
        public int yellow_cards { get; set; }
        [Display(Name = "Red Cards")]
        public int red_cards { get; set; }
        [Display(Name = "Saves")]
        public int saves { get; set; }
        [Display(Name = "Bonus")]
        public int bonus { get; set; }
        [Display(Name = "Bonus Point System")]
        public int bps { get; set; }
        [Display(Name = "Influence")]
        public string influence { get; set; }
        [Display(Name = "Creativity")]
        public string creativity { get; set; }
        [Display(Name = "Threat")]
        public string threat { get; set; }
        [Display(Name = "ICT Index")]
        public string ict_index { get; set; }
        [Display(Name = "Influence Rank")]
        public int influence_rank { get; set; }
        [Display(Name = "Influence Rank Position")]
        public int influence_rank_type { get; set; }
        [Display(Name = "Creativity Rank")]
        public int creativity_rank { get; set; }
        [Display(Name = "Creativity Rank Position")]
        public int creativity_rank_type { get; set; }
        [Display(Name = "Threat Rank")]
        public int threat_rank { get; set; }
        [Display(Name = "Threat Rank Position")]
        public int threat_rank_type { get; set; }
        [Display(Name = "ICT Index Rank")]
        public int ict_index_rank { get; set; }
        [Display(Name = "ICT Index Rank Position")]
        public int ict_index_rank_type { get; set; }
        [Display(Name = "Corner & Indirect Freekicks Order")]
        public int? corners_and_indirect_freekicks_order { get; set; }
        [Display(Name = "Corner & Indirect Freekicks Text")]
        public string corners_and_indirect_freekicks_text { get; set; }
        [Display(Name = "Direct Freekicks Order")]
        public int? direct_freekicks_order { get; set; }
        [Display(Name = "Direct Freekicks Text")]
        public string direct_freekicks_text { get; set; }
        [Display(Name = "Penalties Order")]
        public int? penalties_order { get; set; }
        [Display(Name = "Penalties Text")]
        public string penalties_text { get; set; }

        //Endpoint path: event/{event_id}/live/
        //Gameweek Live Data gets id and stats
        public Stats stats { get; set; }

        //navigationproperties
        //public Team Team { get; set; }
        //public Element_Type Element_Type { get; set; }

        //extra props
        public string element_type_short_name { get; set; }
        [Display(Name = "Club")]
        public string team_name { get; set; }
        [Display(Name = "Name")]
        public string first_name_and_web_name { get; set; }
    }

}
