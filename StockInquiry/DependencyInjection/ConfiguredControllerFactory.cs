using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace StockInquiry.DependencyInjection
{
    public class ConfiguredControllerFactory : DefaultControllerFactory
    {
        private readonly IConfiguredContainer _container;

        public ConfiguredControllerFactory(IConfiguredContainer container)
        {
            _container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (IController)_container.Resolve(controllerType);
        }

        public override void ReleaseController(IController controller)
        {
            _container.Release(controller);
            base.ReleaseController(controller);
        }
    }
}
