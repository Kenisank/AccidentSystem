using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
   public  class AccidentRecords
    {
        public int Id { get; set; }

        public string Address { get; set; }

        [Display(Name ="State")]
        public int StateId { get; set; }

        public States State { get; set; }

        public virtual Persons Withness { get; set; }

        public virtual Persons OtherWithness { get; set; }



        public ICollection<Causes> Causes { get; set; }

        public virtual ICollection<VehicleEntries> VehicleEntries { get; set; }

        public virtual PedestrianEntries PedestrianEntry { get; set; }


        //image evidence
        public virtual Evidences Evidence { get; set; }

        public AccidentRecords()
        {

            Causes = new Collection<Causes>();

            VehicleEntries = new Collection<VehicleEntries>();

        }

    }
}
