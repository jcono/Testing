using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using NUnit.Framework;
using StockInquiry.DependencyInjection;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Tests.Unit.DependencyInjection
{
    public class UnityConfigurationTests
    {
        [Test]
        public void ShouldBeAbleToResolveAllControllers()
        {
            var assemblies = typeof(MvcApplication).Assembly;
            var allTypes = assemblies.GetTypes();
            var controllerTypes = allTypes.Where(x => typeof(IController).IsAssignableFrom(x));

            var configuration = new UnityConfiguration();

            foreach (var controllerType in controllerTypes)
            {
                Assert.That(configuration.Resolve(controllerType), Is.TypeOf(controllerType));
            }
        }

        [Test, Ignore]
        public void ShouldResolveTheSimulators()
        {
            var configuration = new UnityConfiguration();

            var repository = configuration.Resolve<IRepository<SKU>>();

            Assert.That(repository, Is.TypeOf<SimulatedSKURepository>());
//            var simulated = (SimulatedSKURepository)repository;
//            Assert.That(simulated._repository, Is.TypeOf<FakeSKURepository>());
        }
    }
}
