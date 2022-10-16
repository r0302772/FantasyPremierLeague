using FantasyPremierLeague.Models.fixtures.fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.Models.fixtures
{
    //Endpoint path: fixtures/
    public class FixturesRootobject
    {
        public List<Fixture> fixtures { get; set; }
    }
}
