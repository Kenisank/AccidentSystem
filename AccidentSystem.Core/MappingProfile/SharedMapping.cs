using AccidentSystem.Core.Resources.Common;
using AccidentSystem.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccidentSystem.Core.MappingProfile
{
    public class SharedMapping:Profile
    {
        public SharedMapping()
        {

            //model to api resources

            CreateMap<Categories, KeyValuePairResources>();
            CreateMap<Causes, KeyValuePairResources>();
            CreateMap<States, KeyValuePairResources>();
            CreateMap<Types, KeyValuePairResources>();



        }
    }
}