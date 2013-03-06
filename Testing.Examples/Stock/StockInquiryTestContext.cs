using System;
using System.Collections.Generic;
using Testing.Browser;
using Testing.Examples.Stock.Domain;

namespace Testing.Examples.Stock
{
    internal class StockInquiryTestContext : BrowserTestContext
    {
        public Action KnowThatStockExistsFor(IEnumerable<Style> styles)
        {
            throw new NotImplementedException();
        }

        public void WantToMakeAStockInquiry()
        {
            throw new NotImplementedException();
        }

        public Action SearchForTheStyle(Style style)
        {

            throw new NotImplementedException();
        }

        public Action ShouldSee(IEnumerable<SKU> SKUs)
        {
            throw new NotImplementedException();
        }
    }
}