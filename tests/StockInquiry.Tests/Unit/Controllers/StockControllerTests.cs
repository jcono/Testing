using Moq;
using NUnit.Framework;
using StockInquiry.Controllers;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Tests.Unit.Controllers
{
    public class StockControllerTests
    {
        [Test]
        public void ShouldProvideTheCorrectModel()
        {
            const string ID = "some sku id";

            var expectedModel = new[] { new Stock(), new Stock() };
            var repository = new Mock<IRepository<Stock>>();
            repository.Setup(x => x.Find(ID)).Returns(expectedModel);
            var controller = new StockController(repository.Object);

            var result = controller.Find(ID);
            
            Assert.That(result.Model, Is.EqualTo(expectedModel));
        }
    }
}
