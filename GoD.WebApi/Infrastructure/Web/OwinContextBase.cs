using GoD.WebApi.Persistence;

namespace GoD.WebApi.Infrastructure.Web
{
    public class OwinContextBase
    {
        protected ApplicationContext Context => OwinContextHelper.GetContext();
    }
}