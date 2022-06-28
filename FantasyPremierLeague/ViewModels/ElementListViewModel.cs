using FantasyPremierLeague.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.ViewModels
{
    public class ElementListViewModel
    {
        public List<SelectListItem> teams_selectlist { get; set; }
        public List<SelectListItem> element_types_selectlist { get; set; }
        public List<SelectListItem> set_piece_selectlist { get; set; }
        public List<Element> elements_list { get; set; }

        public int team_id { get; set; }
        public int element_type_id { get; set; }
        public int set_piece_id { get; set; }
        public string search_string { get; set; }
    }
}
