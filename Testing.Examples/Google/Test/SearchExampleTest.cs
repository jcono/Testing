using NUnit.Framework;
using Testing.Browser;

namespace Testing.Examples.Google.Test
{
    internal class SearchExampleTest : BrowserTest<SearchExampleTestContext>
    {
        [Test]
        public void Example()
        {
            Scenario("Google returns a result I'm looking for", () =>
            {
                Given(I.AmVisitingGoogle);
                When(I.SearchFor("something"));
                Then(I.FindAResultFor("Something"));
            });
        }
    }
}
