using System;
using System.Collections.Generic;
using System.Linq;
using Models.Domain;
using NUnit.Framework;
using Testing.Browser;
using Testing.Examples.StockInquiry.PageModels;

namespace Testing.Examples.StockInquiry
{
    internal class StockInquiryTestContext : BrowserTestContext
    {
        public Action KnowThatSKUExistsFor(IEnumerable<Style> entireRange)
        {
            return () =>
            {
            };
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

        public Action ShouldSee(IEnumerable<SKU> expectedResults)
        {
            return () =>
            {
                var skuResults = On<StockInquiryResultsPage>().Results;
                Assert.That(skuResults, Is.Not.Empty);
                Assert.That(skuResults.Count(), Is.EqualTo(expectedResults.Count()));

                Assert.That(expectedResults.All(x => skuResults.Any(result => x.Colour == result.Colour &&
                                                                              x.Size == result.Size &&
                                                                              x.StyleCode == result.StyleCode)));
            };
        }
    }
}
