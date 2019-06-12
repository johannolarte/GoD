using Autofac;
using Autofac.Integration.WebApi;
using GoD.WebApi.Core;
using GoD.WebApi.Core.Repositories;
using GoD.WebApi.Persistence;
using GoD.WebApi.Persistence.Repositories;
using Owin;
using System.Data.Entity;
using System.Reflection;
using System.Web.Http;

namespace GoD.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            ConfigureOwinContexts(app);

            ConfigureWebApi(config);

            app.UseAutofacMiddleware(ConfigureDependencyInjection(config));
            
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }

        public void ConfigureOwinContexts(IAppBuilder app)
        {
            app.CreatePerOwinContext(ApplicationContext.Create);
        }

        public IContainer ConfigureDependencyInjection(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<ApplicationContext>().As<DbContext>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<PlayersRepository>().As<IPlayersRepository>().InstancePerRequest();

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return container;
        }

        private void ConfigureWebApi(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}