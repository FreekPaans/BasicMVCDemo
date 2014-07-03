using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication7.Controllers
{
	public class AddNumbers {
		public int basenumber{get;set;}
		public int toaddnumber{get;set;}
	}

    public class AddNumbersController : ApiController
    {
		public int Post(AddNumbers operation) {
			return operation.basenumber + operation.toaddnumber;
		}

		public string Get() {
			return "This function is used to add a couple of numbers";
		}
    }
}
