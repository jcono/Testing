using System;
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

    public class StockInquiryContext : BrowserTestContext
    {
        public void AmTryingToFindStockAvailability()
        {
            throw new System.NotImplementedException();
        }

        public Action SearchForTheStyle(string abc)
        {
            throw new System.NotImplementedException();
        }

        public Action ShouldSeeTheSKUsFor(string abc)
        {
            throw new NotImplementedException();
        }

        public Action KnowThatStockExists(string abc)
        {
            throw new NotImplementedException();
        }
    }
}