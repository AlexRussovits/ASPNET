using System.Web;
using System.Web.Mvc;

namespace FilmsJPTVR18_Russovits
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
