using FantasyPremierLeague.Models;
using FantasyPremierLeague.Models.bootstrap_static;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.DataAcces
{
    public class FPLContext : DbContext
    {
        public FPLContext(DbContextOptions options) : base(options) { }

        public DbSet<BootstrapStaticRootobject> BootstrapStatic { get; set; }  
        //public DbSet<Element> Elements { get; set; }
        //public DbSet<Element_Type> Element_Types { get; set; }
        //public DbSet<Team> Teams { get; set; }
    }
}
