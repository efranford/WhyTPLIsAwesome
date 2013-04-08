using System.Web;
using System.Web.Mvc;

namespace Why_TPL_Is_Awesome
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}