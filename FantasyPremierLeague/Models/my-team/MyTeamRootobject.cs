using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.my_team
{
    public class MyTeamRootobject
    {
        public List<Pick> picks { get; set; }
        public List<Chip> chips { get; set; }
        public Transfers transfers { get; set; }
    }

    public class Transfers
    {
        public int cost { get; set; }
        public string status { get; set; }
        public int limit { get; set; }
        public int made { get; set; }
        public int bank { get; set; }
        public int value { get; set; }
    }

    public class Pick
    {
        public int element { get; set; }
        public int position { get; set; }
        public int selling_price { get; set; }
        public int multiplier { get; set; }
        public int purchase_price { get; set; }
        public bool is_captain { get; set; }
        public bool is_vice_captain { get; set; }
    }

    public class Chip
    {
        public string status_for_entry { get; set; }
        public int?[] played_by_entry { get; set; }
        public string name { get; set; }
        public int number { get; set; }
        public int start_event { get; set; }
        public int stop_event { get; set; }
        public string chip_type { get; set; }
    }

}
