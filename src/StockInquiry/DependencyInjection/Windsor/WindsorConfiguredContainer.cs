using Castle.Windsor;

namespace StockInquiry.DependencyInjection.Windsor
{
    public class WindsorConfiguredContainer: WindsorContainer
    {
        public WindsorConfiguredContainer()
        {
            Install(new SimulatorsConfiguration(), 
                new RepositoryConfiguration(),
                new ControllerRegistration());
        }
    }
}
