using System.Web;
using System.Web.Mvc;

namespace PrimeiraAPP_MVC_PISO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
