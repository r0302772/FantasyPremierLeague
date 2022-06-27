namespace FantasyPremierLeague.Models
{
    public class Result
    {
        public int id { get; set; }
        public int event_total { get; set; } //refers to the event points
        public string player_name { get; set; }
        public int rank { get; set; }
        public int last_rank { get; set; }
        public int rank_sort { get; set; }
        public int total { get; set; } //refers to the total points
        public int entry { get; set; } //refers to the manager id
        public string entry_name { get; set; } //refers to the fantasyteam name
    }
}
