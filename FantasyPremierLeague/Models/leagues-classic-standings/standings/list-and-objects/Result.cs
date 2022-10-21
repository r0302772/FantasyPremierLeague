using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.leagues_classic_standings.standings.list_and_objects
{
    public class Result
    {
        public int id { get; set; }
        public int event_total { get; set; }
        public string player_name { get; set; }
        public int rank { get; set; }
        public int last_rank { get; set; }
        public int rank_sort { get; set; }
        public int total { get; set; }
        public int entry { get; set; }
        public string entry_name { get; set; }

        //extra props
        public int point_difference_first_place { get; set; }
        public int point_difference_last_place { get; set; }
        public int point_difference_place_up { get; set; }
        public int point_difference_place_down { get; set; }
        public int total_points_on_bench { get; set; }
        public int points_from_auto_subs { get; set; }
    }
}
