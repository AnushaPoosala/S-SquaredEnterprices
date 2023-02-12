using System.Web;
using System.Web.Mvc;

namespace S_SquaredEnterprices3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
