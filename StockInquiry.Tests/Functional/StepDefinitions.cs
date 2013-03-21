using StockInquiry.Tests.Functional.PageModels;
using TechTalk.SpecFlow;
using Testing.Framework.Browser;

namespace StockInquiry.Tests.Functional
{
    [Binding]
    public class StepDefinitions : BrowserTestContext
    {
        private const string AppUrl = "http://localhost:22782/";

        public StepDefinitions()
        {
            Reset();
        }

        [Given(@"I know stock exists for (.*)")]
        public void GivenIKnowStockExistsFor(string p0)
        {
        }

        [Given(@"I want to make a stock inquiry")]
        public void GivenIWantToMakeAStockInquiry()
        {
            Launch(AppUrl);
            Wait.For(() => On<StockInquiryPage>().IsReady(), "Stock inquiry page never appeared");
        }

        [When(@"I search for a ""(.*)""")]
        public void WhenISearchForA(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I choose to look at stock for a ""(.*)""")]
        public void WhenIChooseToLookAtStockForA(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the SKU'(.*)'s Shirts""")]
        public void ThenIShouldSeeTheSKUSShirts(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see all the ""(.*)"" stock")]
        public void ThenIShouldSeeAllTheStock(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
