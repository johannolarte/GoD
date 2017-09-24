using GoD.WebApi.Persistence;

namespace GoD.WebApi.Infrastructure.Web
{
    public class OwinContextBase
    {
        protected ApplicationContext _context => OwinContextHelper.GetContext();
    }
}