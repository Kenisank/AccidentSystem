using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
   public  class AccidentEntries
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public States State { get; set; }

        public virtual ICollection<Persons> Withnesses { get; set; }

        public virtual ICollection<Causes> Causes { get; set; }


        //image evidence
        public virtual ICollection<Evidences> Evidences { get; set; }

        public AccidentEntries()
        {
            Withnesses = new Collection<Persons>();

            Causes = new Collection<Causes>();

            Evidences = new Collection<Evidences>();

        }

    }
}
