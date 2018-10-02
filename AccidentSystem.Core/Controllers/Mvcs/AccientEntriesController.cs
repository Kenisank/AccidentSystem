using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccidentSystem.Core.Controllers.Mvcs
{
    public class AccientEntriesController : Controller
    {
        // GET: AccientEntries
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewEntry()
        {
            return View();
        }


    }
}