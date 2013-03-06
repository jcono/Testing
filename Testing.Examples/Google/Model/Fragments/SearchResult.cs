using Testing.Browser;

namespace Testing.Examples.Google.Model.Fragments
{
    public class SearchResult : HtmlFragment
    {
        public SearchResult(IHtmlElement element) : base(element)
        {
        }

        public string Title
        {
            get { return Child("h3.r").Text; }
        }
    }
}
