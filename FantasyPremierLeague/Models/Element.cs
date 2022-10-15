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
        [Display(Name = "Code")]
        public int code { get; set; }
        [Display(Name = "Price Rise Gameweek")]
        public int cost_change_event { get; set; }
        [Display(Name = "Price Fall Gameweek")]
        public int cost_change_event_fall { get; set; }
        [Display(Name = "Price Rise Start")]
        public int cost_change_start { get; set; }
        [Display(Name = "Price Fall Start")]
        public int cost_change_start_fall { get; set; }
        [Display(Name = "Dreamteam Count")]
        public int dreamteam_count { get; set; }
        [Display(Name = "Position")]
        public int element_type { get; set; } //refers to the id in the Element_Type class
        [Display(Name = "EP Next")]
        public string ep_next { get; set; }
        [Display(Name = "EP This")]
        public string ep_this { get; set; }
        [Display(Name = "Gameweek Points")]
        public int event_points { get; set; }
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        [Display(Name = "Form")]
        public string form { get; set; }
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "In Dreamteam")]
        public bool in_dreamteam { get; set; }
        [Display(Name = "News")]
        public string news { get; set; }
        [Display(Name = "News Added")]
        public DateTime? news_added { get; set; }
        [Display(Name = "Cost")]
        public int now_cost { get; set; }
        [Display(Name = "Photo")]
        public string photo { get; set; }
        [Display(Name = "Points Per Game")]
        public string points_per_game { get; set; }
        [Display(Name = "Second Name")]
        public string second_name { get; set; }
        [Display(Name = "Selected By %")]
        public string selected_by_percent { get; set; }
        [Display(Name = "Special")]
        public bool special { get; set; }
        [Display(Name = "Squad Number")]
        public object squad_number { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        [Display(Name = "Team")]
        public int team { get; set; } //refers to the id in the Team class
        [Display(Name = "Team Code")]
        public int team_code { get; set; }
        [Display(Name = "Total Points")]
        public int total_points { get; set; }
        [Display(Name = "Transfered In")]
        public int transfers_in { get; set; }
        [Display(Name = "Transfered In This Gameweek")]
        public int transfers_in_event { get; set; }
        [Display(Name = "Transfered Out")]
        public int transfers_out { get; set; }
        [Display(Name = "Transfered Out This Gameweek")]
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

        //extra props
        public string element_type_short_name { get; set; }
        [Display(Name = "Club")]
        public string team_name { get; set; }
        [Display(Name = "Name")]
        public string first_name_and_web_name { get; set; }
    }

}
