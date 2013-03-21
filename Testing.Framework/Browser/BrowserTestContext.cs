using System;
using System.Collections.Generic;
using Testing.Framework.BDD;
using Testing.Framework.Browser.PageModel;

namespace Testing.Framework.Browser
{
    public abstract class BrowserTestContext : ITestContext
    {
        private static readonly Dictionary<Type, HtmlPage> PagesCache = new Dictionary<Type, HtmlPage>();

        protected IBrowser Browser { get; private set; }

        public void Reset()
        {
            Browser = BrowserFactory.ForWebDriver();
        }

        public void Launch(string address)
        {
            Browser.GoTo(address);
        }

        public T On<T>() where T : HtmlPage, new()
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
            Console.WriteLine(context.Exception.StackTrace);
        }
    }
}
