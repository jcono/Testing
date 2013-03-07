using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
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
            Launch("http://localhost:22782/");
            Wait.For(() => On<StockInquiryPage>().IsReady(), "Stock inquiry page never appeared");
        }

        public Action SearchFor(Style shirt)
        {
            return () =>
                {
                    On<StockInquiryPage>().SearchFor(shirt.StyleCode);

                    Wait.For(() => On<StockInquiryResultsPage>().IsReady(), "Results never came back");
                };
        }

        public Action ShouldSee(IEnumerable<SKU> results)
        {
            return () =>
                {
                    var skuResults = On<StockInquiryResultsPage>().Results;
                    Assert.That(skuResults, Is.Not.Empty);
                    foreach (var result in skuResults)
                    {
                        Assert.That(results.Any(x => x.Colour == result.Colour &&
                                                     x.Size == result.Size &&
                                                     x.StyleCode == result.StyleCode));
                    }
                };
        }
    }
}