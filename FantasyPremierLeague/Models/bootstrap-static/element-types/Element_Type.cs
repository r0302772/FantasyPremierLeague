using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.bootstrap_static.element_types
{
    //Basic information about player’s position (GK, DEF, MID, FWD).
    public class Element_Type
    {
        public int id { get; set; }
        public string plural_name { get; set; }
        public string plural_name_short { get; set; }
        public string singular_name { get; set; }
        public string singular_name_short { get; set; }
        public int squad_select { get; set; }
        public int squad_min_play { get; set; }
        public int squad_max_play { get; set; }
        public bool ui_shirt_specific { get; set; }
        public int?[] sub_positions_locked { get; set; }
        public int element_count { get; set; } //refers to the total elements with that element_type
    }
}
