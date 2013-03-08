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
        public Action KnowThatSKUExistsFor(IEnumerable<SKU> range)
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
                On<StockInquiryPage>().SearchFor(shirt.Code);
                Wait.For(() => On<StockInquiryResultsPage>().IsReady(), "Results never came back");
            };
        }

        public Action ShouldSee(IEnumerable<SKU> expectedResults)
        {
            return () =>
            {
                var results = On<StockInquiryResultsPage>().Results;
                Assert.That(results.Count, Is.EqualTo(expectedResults.Count()));
                foreach (var result in expectedResults)
                {
                    Assert.That(On<StockInquiryResultsPage>().Results.For(result).IsShown());
                }

                Assert.That(expectedResults.All(x => results.Items.Any(result => x.Colour == result.Colour &&
                                                                           x.Size == result.Size &&
                                                                           x.Style.Code == result.StyleCode)));
            };
        }

        public Action ChooseToLookForStockFor(SKU sku)
        {
            return () =>
            {
                //                On<StockInquiryResultsPage>().For(sku).View();
            };
        }

        public Action ShouldSeeTheOptionsFor(IEnumerable<Stock> stocks)
        {
            throw new NotImplementedException();
        }
    }
}
