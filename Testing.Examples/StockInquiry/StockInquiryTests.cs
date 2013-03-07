using NUnit.Framework;
using Testing.Browser;

namespace Testing.Examples.StockInquiry
{
    class StockInquiryTests : BrowserTest<SKUQueryContext>
    {
        [Test]
        public void SimpleSKUQuery()
        {
            Given(I.KnowThatSKUExistsFor(BenSherman.EntireRange)).And(I.AmReadyToMakeAStockInquiry);
            When(I.SearchFor(BenSherman.Shirt));
            Then(I.ShouldSee(BenSherman.Shirt.SKUs));
        }
    }
}
