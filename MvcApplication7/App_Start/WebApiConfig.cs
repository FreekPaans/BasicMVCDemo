using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MvcApplication7 {
	public static class WebApiConfig {
		public static void Register(HttpConfiguration config) {
			//config.Routes.MapHttpRoute(
			//	name :"TestFunctionsAddNumberController",
			//	routeTemplate :"api/TestFunctions/AddNumbers",
			//	defaults :new { controller = "TestFunctionsAddNumber" }
			//);
			config.Routes.MapHttpRoute(
				name :"DefaultApi",
				routeTemplate :"api/{controller}",
				defaults :new { }
			);
		}
	}
}
