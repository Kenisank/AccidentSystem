using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
    public class PedestrianEntries:AffectedPersons
    { 
       

        public int CategoryId { get; set; }

        public Categories Category { get; set; }

       

        

    }
}
