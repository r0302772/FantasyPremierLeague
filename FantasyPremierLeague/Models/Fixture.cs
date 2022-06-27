using System;

namespace FantasyPremierLeague.Models
{
    //Endpoint path: fixtures/
    //Endpoint path: element-summary/{element_id}/
    //A list of player’s remaining fixtures of the season.
    public class Fixture
    {
        public int code { get; set; }
        public int Event { get; set; } //refers to the id in Event class
        public bool finished { get; set; }
        public bool finished_provisional { get; set; }
        public int id { get; set; }
        public DateTime kickoff_time { get; set; }
        public int minutes { get; set; }
        public bool provisional_start_time { get; set; }
        public bool started { get; set; }
        public int team_a { get; set; } //refers to the id in Team class
        public int team_a_score { get; set; }
        public int team_h { get; set; } //refers to the id in Team class
        public int team_h_score { get; set; }
        //public Stat[] stats { get; set; } //from fixtures endpoint
        public int team_h_difficulty { get; set; } //FDR value calculated by FPL
        public int team_a_difficulty { get; set; } //FDR value calculated by FPL
        public int pulse_id { get; set; }

        //Endpoint path: element-summary/{element_id}/
        public string event_name { get; set; }
        public bool is_home { get; set; }
        public int difficulty { get; set; } //FDR value calculated by FPL
    }

    /*    public class Stat
        {
            public string identifier { get; set; }
            public A[] a { get; set; }
            public H[] h { get; set; }
        }

        public class A
        {
            public int value { get; set; }
            public int element { get; set; }
        }

        public class H
        {
            public int value { get; set; }
            public int element { get; set; }
        }*/
}

