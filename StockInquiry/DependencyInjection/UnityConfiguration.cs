using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.DependencyInjection
{
    public class UnityConfiguration : UnityContainer
    {
        public UnityConfiguration()
        {
            var unityConfiguration = this;
            unityConfiguration.RegisterType<IRepository<SKU>, FakeSKURepository>();
            unityConfiguration.RegisterType<IRepository<Stock>, FakeStockRepository>();

            RegisterControllers(this);
        }

        private void RegisterControllers(UnityConfiguration configuration)
        {
            var assembly = typeof(MvcApplication).Assembly;
            var controllers = assembly.GetTypes().Where(x => typeof(IController).IsAssignableFrom(x));
            foreach (var controller in controllers)
            {
                configuration.RegisterType(controller);
            }
        }
    }
}
