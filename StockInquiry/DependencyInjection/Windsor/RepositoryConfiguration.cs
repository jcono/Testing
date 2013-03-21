using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.DependencyInjection.Windsor
{
    public class RepositoryConfiguration : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IRepository<SKU>>().ImplementedBy<FakeSKURepository>());
            container.Register(Component.For<IRepository<Stock>>().ImplementedBy<FakeStockRepository>());
        }
    }
}
