using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication7.Controllers
{
    public class ErrorHandlerController : Controller
    {	
		
        public ActionResult ReportDefault()
        {
			return View();
        }
    }
}
