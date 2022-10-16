using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.fixtures.fixtures;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.ViewModels
{
    public class FixtureListViewModel
    {
        public List<Fixture> fixtures_list { get; set; }

        public List<SelectListItem> teams_selectlist { get; set; }
        public List<SelectListItem> events_selectlist { get; set; }
        public List<SelectListItem> phases_selectlist { get; set; }

        public int team_id { get; set; }
        public int event_id { get; set; }
        public int phase_id { get; set; }

        public int prediction_true_count { get; set; }
        public int team_h_win_count { get; set; }
        public int draw_count { get; set; }
        public int draw_predicted_count { get; set; }
    }
}
