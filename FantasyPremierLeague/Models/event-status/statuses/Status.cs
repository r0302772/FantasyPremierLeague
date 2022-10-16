using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.event_status.statuses
{
    public class Status
    {
        public bool bonus_added { get; set; }
        public string date { get; set; }
        public int Event { get; set; }
        public string points { get; set; }
    }
}
