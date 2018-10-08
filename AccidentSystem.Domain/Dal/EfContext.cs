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

        public DbSet<PedestrianEntries> PedestrianEntries { get; set; }       
        
        public DbSet<States> States { get; set; } 

        public DbSet<Types> Types { get; set; }

        public DbSet<VehicleEntries> VechicleEntries { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Types>().HasRequired(t=>t.Category).WithMany(c=>c.Types).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Categories>

            //modelBuilder.Entity<Agent>().HasMany(t => t.Tenants).WithRequired(a => a.Agent).WillCascadeOnDelete(false);
            //modelBuilder.Entity<Tenant>().HasRequired(a => a.Agent).WithMany(t => t.Tenants).WillCascadeOnDelete(false);



            //modelBuilder.Entity<Companies>().HasOptional(m => m.State).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<States>().HasRequired(n => n.Country).WithMany(o => o.States).WillCascadeOnDelete(false);
            //modelBuilder.Entity<LGAs>().HasRequired(a => a.State).WithMany(b => b.LGA).WillCascadeOnDelete(false);
            //modelBuilder.Entity<EducationBackgrounds>().HasRequired(e => e.Country).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Candidates>().HasRequired(e => e.State).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Candidates>().HasRequired(e => e.Origin).WithMany().WillCascadeOnDelete(false);
            // modelBuilder.Entity<Jobs>().HasRequired(f => f.JobType).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Jobs>().HasRequired(f => f.JobLevel).WithMany().WillCascadeOnDelete(false);

            // modelBuilder.Entity<Specializations>().HasRequired(d => d.Level).WithMany(q => q.Specializations).WillCascadeOnDelete(false);
            base.OnModelCreating(modelBuilder);
        }



        public static EfContext Create() { return new EfContext(); }



    }
}
