using FantasyPremierLeague.Models.event_live.elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.event_live
{
    //Endpoint path: event/{event_id}/live/
    public class EventLiveRootobject
    {
        //A list of players’ information in that specific Gameweek
        public List<Element> elements { get; set; }
    }
}
