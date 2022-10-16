using System.Collections.Generic;

namespace FantasyPremierLeague.Models
{
    public class Fixture_Stat
    {
        public string identifier { get; set; }
        public List<Fixture_Element> a { get; set; }
        public List<Fixture_Element> h { get; set; }
    }
}
