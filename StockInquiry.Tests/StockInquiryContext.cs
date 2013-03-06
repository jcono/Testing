using System;
using Testing.Browser;

namespace StockInquiry.Tests
{
    public class StockInquiryContext : BrowserTestContext
    {
        public void AmTryingToFindStockAvailability()
        {
            Launch("http://localhost:11179");
        }

        public Action SearchForTheStyle(string abc)
        {
            return () => On<HomePage>().SearchFor(abc);
        }

        public Action ShouldSeeTheSKUsFor(string abc)
        {
            throw new NotImplementedException();
        }

        public Action KnowThatStockExists(string abc)
        {
            return () => { };
        }
    }
}