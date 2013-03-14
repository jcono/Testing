using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using StockInquiry.Models.Domain;
using StockInquiry.Tests.Functional.PageModels;
using Testing.Framework.Browser;

namespace StockInquiry.Tests.Functional
{
    internal class StockInquiryTestContext : BrowserTestContext
    {
        private const string AppUrl = "http://localhost:22782/";

        public Action KnowThatStockExistsFor(IEnumerable<SKU> range)
        {
            return () =>
            {
            };
        }

        public void AmReadyToMakeAStockInquiry()
        {
            Launch(AppUrl);
            Wait.For(() => On<StockInquiryPage>().IsReady(), "Stock inquiry page never appeared");
        }

        public Action SearchFor(Style shirt)
        {
            return () =>
            {
                On<StockInquiryPage>().SearchFor(shirt.Code);
                Wait.For(() => On<SKUInquiryResultsPage>().IsReady(), "Results never came back");
            };
        }

        public Action ShouldSeeTheProductsFor(IEnumerable<SKU> expectedResults)
        {
            return () =>
            {
                var results = On<SKUInquiryResultsPage>().Results;
                Assert.That(results.Count, Is.EqualTo(expectedResults.Count()));
                foreach (var result in expectedResults)
                {
                    Assert.That(On<SKUInquiryResultsPage>().Results.For(result).IsShown());
                }
            };
        }

        public Action ChooseToLookForStockFor(SKU sku)
        {
            return () =>
            {
                On<SKUInquiryResultsPage>().Results.For(sku).View();
                Wait.For(() => On<StockInquiryResultsPage>().IsReady(), "The stock results never appeared");
            };
        }

        public Action ShouldSeeThe(IEnumerable<Stock> expectedResults)
        {
            return () =>
            {
                var results = On<StockInquiryResultsPage>().Results;
                Assert.That(results.Count, Is.EqualTo(expectedResults.Count()));
                foreach (var result in expectedResults)
                {
                    Assert.That(On<StockInquiryResultsPage>().Results.For(result).IsShown());
                }
            };
        }
    }
}
