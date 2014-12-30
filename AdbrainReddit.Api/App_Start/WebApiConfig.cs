using System.Web.Http;
using AdbrainReddit.Api.Resolver;
using AdbrainReddit.Data;
using AdbrainReddit.Repository;
using AdbrainReddit.Services;
using Microsoft.Practices.Unity;

namespace AdbrainReddit.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            //jsonFormatter.SerializerSettings.ContractResolver =
             //new CamelCasePropertyNamesContractResolver();

            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IDbContext, RedditDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IRedditService, RedditService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);




            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
