using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebApplication.Infrastructure;
using Domain.Concrete;

namespace WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DomainSchemas.GenerateAllSchemas();

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
        }
    }
}
