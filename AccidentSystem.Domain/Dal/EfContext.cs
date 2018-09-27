using AccidentSystem.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal
{
    public class EfContext:IdentityDbContext<ApplicationUser>
    {


        public EfContext():base("EfContext") { }

        public DbSet<AccidentRecords> AccidentRecords { get; set; }

        public DbSet<AffectedPersons> AffectedPersons { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Causes> Causes { get; set; }

        public DbSet<Evidences> Evidences { get; set; }

        public DbSet<PedestrianEntries> PedestrianEntries { get; set; }       
        
        public DbSet<States> States { get; set; } 

        public DbSet<Types> Types { get; set; }

        public DbSet<VehicleEntries> VechicleEntries { get; set; }



        public static EfContext Create() { return new EfContext(); }


    }
}
