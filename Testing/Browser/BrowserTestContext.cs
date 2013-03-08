using System;
using System.Collections.Generic;
using Testing.BDD;
using Testing.Browser.PageModel;

namespace Testing.Browser
{
    public abstract class BrowserTestContext : ITestContext
    {
        private static readonly Dictionary<Type, HtmlPage> PagesCache = new Dictionary<Type, HtmlPage>();

        protected IBrowser Browser { get; private set; }

        public void Reset()
        {
            Browser = BrowserFactory.ForWebDriver();
        }

        protected void Launch(string address)
        {
            Browser.GoTo(address);
        }

        protected T On<T>() where T : HtmlPage, new()
        {
            var type = typeof(T);
            if (!PagesCache.ContainsKey(type))
            {
                var page = new T().OnBrowser(Browser);
                PagesCache.Add(type, page);
            }

            return (T)PagesCache[type];
        }

        public void OnScenarioFailed(ScenarioFailure context)
        {
        }
    }
}
