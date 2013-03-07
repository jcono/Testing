using System;
using System.Collections.Generic;
using Testing.Browser;

namespace Testing.Examples.StockInquiry
{
    internal class SKUQueryContext : BrowserTestContext
    {
        public Action KnowThatSKUExistsFor(IEnumerable<Style> entireRange)
        {
            return () => { };
        }

        public void AmReadyToMakeAStockInquiry()
        {
            Launch("http://localhost:11179/");
            Wait.For(() => On<StockInquiryPage>().IsReady(), "Stock inquiry page never appeared");
        }
    }
}