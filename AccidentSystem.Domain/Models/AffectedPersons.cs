using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccidentSystem.Domain.Models
{
   public class AffectedPersons
    {

        public int Id { get; set; }

        public int AccidentRecordId { get; set; }

        public virtual AccidentRecords AccidentRecord { get; set; }

        // Number of dead persons
        public int DeadMale { get; set; }

        public int DeadFemale { get; set; }


        // Number of hurt persons
        public int HurtMale { get; set; }
        public int HurtFemale { get; set; }

        // Number of survied persons
        public int SurviedMale { get; set; }
        public int SurviedFemale { get; set; }




        //total number of persons and driver

        public int Dead => DeadFemale + DeadMale;

        public int Hurt => HurtFemale + HurtMale;

        public int Survied => SurviedFemale + SurviedMale;

        public int Total => Dead + Hurt + Survied;
    }
}
