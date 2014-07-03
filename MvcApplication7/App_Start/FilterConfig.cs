using System.Web;
using System.Web.Mvc;

namespace MvcApplication7 {
	public class FilterConfig {
		public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
			var attr = new AuthorizeAttribute();
			attr.Users = "freek";
			filters.Add(attr);
			filters.Add(new HandleErrorAttribute());
		}
	}
}