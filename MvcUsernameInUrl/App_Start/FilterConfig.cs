using System.Web;
using System.Web.Mvc;

namespace MvcUsernameInUrl
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new RedirectLoggedOnUserFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
