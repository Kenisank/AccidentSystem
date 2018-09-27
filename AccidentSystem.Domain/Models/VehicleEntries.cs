using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
   public class VehicleEntries:AffectedPersons
    {
        

        public int TypeId { get; set; }

        //type of vehicle
        public Types Type { get; set; }

        public string PlateNo { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public int Passagers => Total - 1;

        public int Driver => 1;

      

        public string NumOfPersons => $"A Driver and {Dead + Hurt + Survied} passagers";


      
    }
}
