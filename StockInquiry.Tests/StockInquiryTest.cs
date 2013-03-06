using NUnit.Framework;
using Testing.Browser;

namespace StockInquiry.Tests
{
    public class StockInquiryTest: BrowserTest<StockInquiryContext>
    {
        [Test]
        public void SimpleSKUInquiry()
        {
            Given(I.AmTryingToFindStockAvailability).And(I.KnowThatStockExists("ABC"));
            When(I.SearchForTheStyle("ABC"));
            Then(I.ShouldSeeTheSKUsFor("ABC"));
        }
        [Test]
        public void NoResultSKUInquiry()
        {
        }

    }
}