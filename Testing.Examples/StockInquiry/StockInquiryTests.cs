using NUnit.Framework;
using Testing.Browser;
using Testing.Data;

namespace Testing.Examples.StockInquiry
{
    internal class StockInquiryTests : BrowserTest<StockInquiryTestContext>
    {
        [Test]
        public void SimpleStockInquiry()
        {
            Scenario("Simple stock inquiry", () =>
            {
                Given(I.KnowThatSKUExistsFor(BenShermans.EntireRange));
                And(I.AmReadyToMakeAStockInquiry);
                When(I.SearchFor(BenShermans.Shirt));
                Then(I.ShouldSee(BenShermans.Shirts.All));

//                When(I.ChooseToLookForStockFor(BenShermans.Shirts.MediumBlack));
//                Then(I.ShouldSeeTheOptionsFor(BenShermans.MediumBlackShirtStock));
            });
        }
    }
}
