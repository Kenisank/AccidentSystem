using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
   public  class AccidentRecords
    {
        public int Id { get; set; }

        public string Address { get; set; }


        public int StateId { get; set; }

        public States State { get; set; }

        public virtual Persons Withnesses { get; set; }

        public virtual Persons OtherWithnesses { get; set; }



        public ICollection<Causes> Causes { get; set; }

        public virtual ICollection<VehicleEntries> VehicleEntries { get; set; }

        public virtual PedestrianEntries PedestrianEntry { get; set; }


        //image evidence
        public virtual Evidences Evidences { get; set; }

        public AccidentRecords()
        {

            Causes = new Collection<Causes>();

            Evidences = new Evidences();

            VehicleEntries = new Collection<VehicleEntries>();

        }

    }
}
