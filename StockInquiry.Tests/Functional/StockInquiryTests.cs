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
                Given(I.KnowThatStockExistsFor(BenSherman.EntireRange));
                And(I.AmReadyToMakeAStockInquiry);
                When(I.SearchFor(Styles.BenShermanShirt));
                Then(I.ShouldSeeTheProductsFor(BenSherman.Shirt.All));

                When(I.ChooseToLookForStockFor(BenSherman.Shirt.InMediumBlack));
                Then(I.ShouldSeeThe(BenSherman.StockOf.Shirts.MediumBlackShirts));
            });
        }
    }
}
