using System.Collections.Generic;
using System.Linq;
using Testing.Browser;
using Testing.Examples.Google.Model.Fragments;

namespace Testing.Examples.Google.Model.Pages
{
    internal class HomePage : HtmlPage
    {
        public void SearchFor(string searchTerm)
        {
            SearchBox.Type(searchTerm);
            SearchButton.Click();
            Wait.For(() => Child("#rcnt").Visible, "The results never came back!!!");
        }

        private IHtmlElement SearchButton
        {
            get { return Child("#gbqfb"); }
        }

        private IHtmlElement SearchBox
        {
            get { return Child("#gbqfq"); }
        }

        public IEnumerable<SearchResult> Results
        {
            get { return Children("li.g").Select(x => new SearchResult(x)); }
        }
    }
}
