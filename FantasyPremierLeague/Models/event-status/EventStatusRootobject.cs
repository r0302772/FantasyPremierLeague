using FantasyPremierLeague.Models.event_status.statuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.event_status
{
    //Endpoint path: event-status/
    public class EventStatusRootobject
    {
        public string endpoint { set { endpoint = "event-status/"; } }
        public List<Status> status { get; set; }
        public string leagues { get; set; }
    }
}
