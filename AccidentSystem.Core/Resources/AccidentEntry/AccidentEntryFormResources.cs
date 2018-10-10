using AccidentSystem.Core.Resources.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccidentSystem.Core.Resources.AccidentEntry
{
    public class AccidentEntryFormResources
    {

        public string Address { get; set; }

        public int StateId { get; set; }

        public PersonsResources Withness { get; set; }

        public PersonsResources OtherWithness { get; set; }

        public EvidencesResources Evidence { get; set; }

    }
}