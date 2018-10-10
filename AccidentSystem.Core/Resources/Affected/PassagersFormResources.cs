using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccidentSystem.Core.Resources.Affected
{
    public class PassagersFormResources
    {
        public int DeadMale { get; set; }

        public int DeadFemale { get; set; }


        // Number of hurt persons
        public int HurtMale { get; set; }
        public int HurtFemale { get; set; }

        // Number of survied persons
        public int SurviedMale { get; set; }
        public int SurviedFemale { get; set; }

    }
}