namespace FantasyPremierLeague.Models
{
    //Endpoint path: dream-team/{event_id}/
    public class Top_Element_Info
    {
        public int id { get; set; } //refers to the id in Element class
        public int points { get; set; }

        //extra props
        public string first_and_web_name { get; set; }
    }
}
