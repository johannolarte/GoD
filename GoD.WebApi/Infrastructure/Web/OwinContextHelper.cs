using GoD.WebApi.Persistence;
using Microsoft.AspNet.Identity.Owin;
using System.Web;

namespace GoD.WebApi.Infrastructure.Web
{
    public class OwinContextHelper
    {
        public static ApplicationContext GetContext()
        {
            return HttpContext.Current.GetOwinContext().Get<ApplicationContext>();
        }
    }
}