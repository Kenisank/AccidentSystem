using AccidentSystem.Domain.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Dal
{
    public class EfContext:IdentityDbContext<ApplicationUser>
    {


        public EfContext():base("EfContext") { }

        public static EfContext Create() { return new EfContext(); }


    }
}
