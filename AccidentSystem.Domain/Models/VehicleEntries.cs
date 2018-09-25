using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
   public class VehicleEntries
    {
        public string PlateNo { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }


        //Number Of Affected Persons
        public virtual AffectedPersons AffectedPerson { get; set; }

        public string NumOfPersons => $"A Driver and {AffectedPerson.Dead + AffectedPerson.Hurt + AffectedPerson.Survied} passagers";

        public VehicleEntries()
        {
            AffectedPerson = new AffectedPersons();
        }
    }
}
