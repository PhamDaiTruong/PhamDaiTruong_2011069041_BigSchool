using System.Web;
using System.Web.Mvc;

namespace PhamDaiTruong_2011069041
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
