using FantasyPremierLeague.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.ViewModels
{
    public class DreamteamListViewModel
    {
        public List<Event> events_list { get; set; }

        public List<string> top_element_first_and_web_names { get; set; }
    }
}
