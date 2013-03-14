using NUnit.Framework;
using StockInquiry.Tests.Data;
using Testing.Framework.Browser;

namespace StockInquiry.Tests.Functional
{
    internal class StockInquiryTests : BrowserTest<StockInquiryTestContext>
    {
        [Test]
        public void SimpleStockInquiry()
        {
            Scenario("Simple stock inquiry", () =>
            {
                Given(I.KnowThatStockExistsFor(BenShermans.EntireRange));
                And(I.AmReadyToMakeAStockInquiry);
                When(I.SearchFor(BenShermans.Shirts.Style));
                Then(I.ShouldSeeTheProductsFor(BenShermans.Shirts.All));

                When(I.ChooseToLookForStockFor(BenShermans.Shirts.InMediumBlack));
                Then(I.ShouldSeeThe(BenShermans.MediumBlackShirtStock));
            });
        }
    }
}
