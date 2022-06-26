using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models
{
    //A list of the best players of the {event_id} gameweek
    public class Dreamteam
    {
        public int element { get; set; } //refers to the id in Element class
        public int points { get; set; }
        public int position { get; set; }
    }

}
