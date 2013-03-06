using NUnit.Framework;
using Testing.Browser;
using Testing.Examples.Stock.TestData;

namespace Testing.Examples.Stock
{
    internal class StockInquiryTest : BrowserTest<StockInquiryTestContext>
    {
        [Test]
        public void SimpleInquiry()
        {
            Scenario("User makes a simple inquiry about stock with a style code", () =>
            {
                Given(I.KnowThatStockExistsFor(BenShermans.EntireRange));
                And(I.WantToMakeAStockInquiry);
                When(I.SearchForTheStyle(BenShermans.MensJeans));
                Then(I.ShouldSee(BenShermans.MensJeans.SKUs));
            });
        }
    }
}
