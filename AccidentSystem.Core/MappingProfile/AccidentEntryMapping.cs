using AccidentSystem.Core.Resources.AccidentEntry;
using AccidentSystem.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccidentSystem.Core.MappingProfile
{
    public class AccidentEntryMapping:Profile
    {
        public AccidentEntryMapping()
        {

            //api resources to model
            CreateMap<AccidentEntryFormResources, AccidentRecords>()
                .ForMember(a => a.Id, opt => opt.Ignore());


                



        }
    }
}