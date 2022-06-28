using System.ComponentModel.DataAnnotations;

namespace FantasyPremierLeague.Models
{
    //Endpoint path: dream-team/{event_id}/
    //A list of the best players of the {event_id} gameweek
    public class Dreamteam
    {
        public int element { get; set; } //refers to the id in Element class
        [Display(Name = "Points")]
        public int points { get; set; }
        [Display(Name = "Position")]
        public int position { get; set; }

        //extra props
        [Display(Name = "Name")]
        public string first_name_and_web_name { get; set; }
        public int team { get; set; }
        [Display(Name = "Club")]
        public string team_name { get; set; }
    }

}
