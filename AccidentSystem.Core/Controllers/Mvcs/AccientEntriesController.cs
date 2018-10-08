using AccidentSystem.Core.Dtos;
using AccidentSystem.Domain.Dal;
using System.Data.Entity;
using AccidentSystem.Domain.Dal.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccidentSystem.Core.Controllers.Mvcs
{

    
    public class AccientEntriesController : Controller
    {

        private readonly EfContext context;

        public AccientEntriesController()
        {
            context = new EfContext();
        }
        
       
        // GET: AccientEntries
        public ActionResult Index()
        {

           
           
            return View();
        }

        [HttpGet]
        public ActionResult NewEntry()
        {

            var state = context.States.ToList();
            var accidentEntryDto = new AccidentEntryDto
            {
                States = state
            };

            return View("Form", accidentEntryDto);
        }

       


    }
}