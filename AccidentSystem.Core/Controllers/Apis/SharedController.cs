using AccidentSystem.Core.Resources.Common;
using AccidentSystem.Domain.Dal.UnitOfWork.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccidentSystem.Core.Controllers.Apis
{

    [RoutePrefix("api/shared")]
    public class SharedController : ApiController
    {

        private readonly IUnitOfWork _unitofwork;
        public SharedController() { }

        public SharedController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
       

        [Route("categories")]
        [HttpGet]
        public IHttpActionResult GetCategories()
        {
            var categories = Mapper.Map<IEnumerable<KeyValuePairResources>>(_unitofwork.Categories);
            return Ok(categories);
        }


        [Route("causes")]
        [HttpGet]
        public IHttpActionResult GetCauses()
        {
            var causes = Mapper.Map<IEnumerable<KeyValuePairResources>>(_unitofwork.Causes);
            return Ok(causes);
        }

        [Route("states")]
        [HttpGet]
        public IHttpActionResult GetStates()
        {
            var states = Mapper.Map<IEnumerable<KeyValuePairResources>>(_unitofwork.States);
            return Ok(states);
        }

        [Route("types")]
        [HttpGet]
        public IHttpActionResult GetTypes()
        {
            var types = Mapper.Map<IEnumerable<KeyValuePairResources>>(_unitofwork.Types);
            return Ok(types);
        }

    }
}
