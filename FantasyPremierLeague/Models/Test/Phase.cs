namespace FantasyPremierLeague.Models
{
    //Endpoint path: bootstrap-static/
    //Phases of FPL season.
    public class Phase
    {
        public int id { get; set; }
        public string name { get; set; }
        public int start_event { get; set; }
        public int stop_event { get; set; }
    }
}
