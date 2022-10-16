namespace FantasyPremierLeague.Models
{
    //Endpoint path: bootstrap-static/
    //The game settings and rules.
    public class Game_Settings
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
        //
        public int squad_squadplay { get; set; }
        public int squad_squadsize { get; set; }
        public int squad_team_limit { get; set; }
        public int squad_total_spend { get; set; }
        //
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
}
