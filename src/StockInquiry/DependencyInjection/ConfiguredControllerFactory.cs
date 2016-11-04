//using System;
//using System.ServiceModel.Channels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Controllers;
//
//namespace StockInquiry.DependencyInjection
//{
//    public class ConfiguredControllerFactory : DefaultControllerFactory
//    {
//        private readonly IConfiguredContainer _container;
//
//        public ConfiguredControllerFactory(IConfiguredContainer container): base()
//        {
//            _container = container;
//        }
//
//        protected override Controller GetControllerInstance(RequestContext requestContext, Type controllerType)
//        {
//            return (Controller)_container.Resolve(controllerType);
//        }
//
//        public override void ReleaseController(IController controller)
//        {
//            _container.Release(controller);
//            base.ReleaseController(controller);
//        }
//    }
//}
