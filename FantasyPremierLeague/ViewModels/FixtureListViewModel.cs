using FantasyPremierLeague.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.ViewModels
{
    public class FixtureListViewModel
    {
        //public PaginatedList<Fixture> Fixtures { get; set; }
        public Fixture[] events { get; set; }
        //public Team[] teams { get; set; }
        //public Team team { get; set; }

        public int Event { get; set; }

        [DataType(DataType.Date)]
        public DateTime kickoff_time { get; set; }
        public int minutes { get; set; }
        public int team_a { get; set; }
        public int team_a_score { get; set; }
        public int team_h { get; set; }
        public int team_h_score { get; set; }
    }
}
