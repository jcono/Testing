using System.Linq;
using System.Web.Mvc;
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
            var assemblies = typeof(MvcApplication).Assembly;
            var allTypes = assemblies.GetTypes();
            var controllerTypes = allTypes.Where(x => typeof(IController).IsAssignableFrom(x));

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
