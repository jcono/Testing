using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using StockInquiry.DependencyInjection.Windsor;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Tests.Unit.DependencyInjection
{
    public class CastleWindsorConfigurationTests
    {
        [Test]
        public void ShouldBeAbleToResolveAllControllers()
        {
            var assemblies = typeof(Startup).Assembly;
            var allTypes = assemblies.GetTypes();
            var controllerTypes = allTypes.Where(x => typeof(Controller).IsAssignableFrom(x));

            var configuration = new WindsorConfiguredContainer();

            foreach (var controllerType in controllerTypes)
            {
                Assert.That(configuration.Resolve(controllerType), Is.TypeOf(controllerType));
            }
        }

        [Test]
        public void ShouldResolveTheSimulators()
        {
            var configuration = new WindsorConfiguredContainer();

            var repository = configuration.Resolve(typeof(IRepository<SKU>));

            Assert.That(repository, Is.TypeOf<SimulatedSKURepository>());
        }
    }
}
