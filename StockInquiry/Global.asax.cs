using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using StockInquiry.App_Start;
using StockInquiry.DependencyInjection;

namespace StockInquiry
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            ConfigureContollerFactory();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        private static void ConfigureContollerFactory()
        {
            var configuration = new UnityConfiguration();
            var controllerFactory = new UnityControllerFactory(configuration);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}
