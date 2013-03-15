using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

namespace StockInquiry.DependencyInjection
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private readonly IUnityContainer _container;

        public UnityControllerFactory(IUnityContainer container)
        {
            _container = container;
        }

        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            return (IController)_container.Resolve(GetControllerType(requestContext, controllerName));
        }

        public override void ReleaseController(IController controller)
        {
            _container.Teardown(controller);
            base.ReleaseController(controller);
        }
    }
}
