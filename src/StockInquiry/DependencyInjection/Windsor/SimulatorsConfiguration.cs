using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Microsoft.AspNetCore.Http;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.DependencyInjection.Windsor
{
    public class SimulatorsConfiguration: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IHttpContextAccessor>().ImplementedBy<HttpContextAccessor>());
            container.Register(Component.For<ISimulatorDecider, SimulatorDecider>());
            container.Register(Component.For<IRepository<SKU>>().ImplementedBy<SimulatedSKURepository>());
        }
    }
}
