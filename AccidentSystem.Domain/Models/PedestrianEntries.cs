using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
    public class PedestrianEntries
    {

        // Number of dead Pedestrian
        public int DeadMale { get; set; }

        public int DeadFemale { get; set; }


        // Number of hurt Pedestrian
        public int HurtMale { get; set; }
        public int HurtFemale { get; set; }


        // Number of survied Pedestrian
        public int SurviedMale { get; set; }
        public int SurviedFemale { get; set; }


        //Number Of Affected Persons
        public virtual AffectedPersons AffectedPerson { get; set; }

        public PedestrianEntries()
        {
            AffectedPerson = new AffectedPersons();
        }




    }
}
