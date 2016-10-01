using System.Web;
using System.Web.Mvc;

namespace CS4250.Prototype.jsTree
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
