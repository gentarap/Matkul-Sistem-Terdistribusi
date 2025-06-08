using System.Web;
using System.Web.Mvc;

namespace MvcApp_22SA11A116
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
