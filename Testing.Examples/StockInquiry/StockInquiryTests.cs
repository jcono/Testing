using NUnit.Framework;
using Testing.Browser;
using Testing.Data;

namespace Testing.Examples.StockInquiry
{
    internal class StockInquiryTests : BrowserTest<StockInquiryTestContext>
    {
        [Test]
        public void SimpleSKUQuery()
        {
            Scenario("Simple stock inquiry", () =>
            {
                Given(I.KnowThatSKUExistsFor(BenShermans.EntireRange));
                And(I.AmReadyToMakeAStockInquiry);
                When(I.SearchFor(BenShermans.Shirt));
                Then(I.ShouldSee(BenShermans.Shirt.SKUs));                
            });
        }
    }
}
