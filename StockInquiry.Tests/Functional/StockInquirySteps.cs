using StockInquiry.Tests.Data;
using StockInquiry.Tests.Functional.PageModels;
using TechTalk.SpecFlow;
using Testing.Framework.BDD;
using Testing.Framework.Browser;
using Testing.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Functional
{
    [Binding]
    public class StockInquirySteps : BrowserSteps
    {
        private const string AppUrl = "http://localhost:22782/";

        public StockInquirySteps(StockInquiryTest context) : base(context)
        {
        }

        [Given(@"I know stock exists for (.*)")]
        public void GivenIKnowStockExistsFor(string key)
        {
        }

        [Given(@"I want to make a stock inquiry")]
        public void GivenIWantToMakeAStockInquiry()
        {
            Launch(AppUrl);
            Wait.For(() => On<StockInquiryPage>().IsReady(), "Stock inquiry page never appeared");
        }

        [When(@"I search for the style ""(.*)""")]
        public void WhenISearchForTheStyle(string styleDescription)
        {

            On<StockInquiryPage>().SearchFor(Styles.FindCodeFor(styleDescription));
            Wait.For(() => On<SKUInquiryResultsPage>().IsReady(), "Results never came back");
        }

        [Then(@"I should see the SKU's for (.*)")]
        public void ThenIShouldSeeTheSKUsFor(string description)
        {
        }

        [When(@"I choose to look at stock for a ""(.*)""")]
        public void WhenIChooseToLookAtStockForA(string p0)
        {
        }

        [Then(@"I should see all the ""(.*)"" stock")]
        public void ThenIShouldSeeAllTheStock(string p0)
        {
        }
    }

    public class BrowserSteps
    {
        private readonly BrowserTestContext _context;

        protected BrowserSteps(BrowserTestContext context)
        {
            _context = context;
        }

        protected void Launch(string address)
        {
            _context.Launch(address);
        }

        protected T On<T>() where T : HtmlPage, new()
        {
            return _context.On<T>();
        }
    }

    public class StockInquiryTest : BrowserTestContext
    {
        public StockInquiryTest()
        {
            Reset();
        }
    }
}
