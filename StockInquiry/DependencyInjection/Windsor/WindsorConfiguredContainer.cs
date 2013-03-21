using System;
using Castle.Windsor;

namespace StockInquiry.DependencyInjection.Windsor
{
    public class WindsorConfiguredContainer : IConfiguredContainer
    {
        private readonly WindsorContainer _container = new WindsorContainer();

        public WindsorConfiguredContainer()
        {
            _container.Install(new SimulatorsConfiguration(),
                               new RepositoryConfiguration(),
                               new ControllerRegistration());
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void Release(object instance)
        {
            _container.Release(instance);
        }
    }
}
