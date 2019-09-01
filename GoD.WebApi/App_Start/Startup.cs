using Autofac;
using Autofac.Integration.WebApi;
using GoD.WebApi.Persistence;
using Owin;
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

            builder.RegisterAssemblyTypes(Assembly.Load(Assembly.GetExecutingAssembly().GetName().Name))
                .AsImplementedInterfaces()
                .InstancePerRequest();

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