using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PORTALJAGUARAO.Controllers
{
    public class ExamePeriodicoController : Controller
    {
        // GET: ExamePeriodico
        public ActionResult ExamesPeriodicos()
        {
            return View();
        }

        public ActionResult ExamePeriodicos2(Models.ExamePeriodico exame)
        {
            return View();
        }
    }
}