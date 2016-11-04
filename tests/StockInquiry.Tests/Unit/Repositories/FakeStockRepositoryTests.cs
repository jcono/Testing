using NUnit.Framework;
using StockInquiry.Models;
using StockInquiry.Models.Data;

namespace StockInquiry.Tests.Unit.Repositories
{
    public class FakeStockRepositoryTests
    {
        [Test]
        public void ShouldReturnStockForMediumBlackShirts()
        {
            var repository = new FakeStockRepository();

            var stock = repository.Find(BenSherman.Shirt.InMediumBlack.Id);

            Assert.That(stock, Is.EqualTo(BenSherman.StockOf.Shirts.MediumBlackShirts));
        }
    }
}