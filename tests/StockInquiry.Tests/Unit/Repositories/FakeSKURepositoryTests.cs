using NUnit.Framework;
using StockInquiry.Models;
using StockInquiry.Models.Data;

namespace StockInquiry.Tests.Unit.Repositories
{
    public class FakeSKURepositoryTests
    {
        [Test]
        public void ShouldReturnBenShermanShirts()
        {
            var repository = new FakeSKURepository();

            var skus = repository.Find(Styles.BenShermanShirt.Code);

            Assert.That(skus, Is.EqualTo(BenSherman.Shirt.All));
        }

        [Test]
        public void ShouldReturnBenShermanScarf()
        {
            var repository = new FakeSKURepository();

            var skus = repository.Find(BenSherman.Scarf.Style.Code);

            Assert.That(skus, Is.EqualTo(BenSherman.Scarf.All));            
        }
    }
}