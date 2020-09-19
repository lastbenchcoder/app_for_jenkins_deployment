using System.Web;
using System.Web.Mvc;

namespace App_For_Jenkins_Deployment
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
