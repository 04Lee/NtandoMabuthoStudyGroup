using System.Web;
using System.Web.Mvc;

namespace NtandoMabuthoStudyGroup
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
