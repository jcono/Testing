using System;
using System.Collections.Generic;
using System.Diagnostics;
using StockInquiry.Tests.Framework.BDD;
using StockInquiry.Tests.Framework.Browser.PageModel;

namespace StockInquiry.Tests.Framework.Browser
{
    public abstract class BrowserTestContext: ITestContext
    {
        private static readonly Dictionary<Type, HtmlPage> PagesCache = new Dictionary<Type, HtmlPage>();

        protected IBrowser Browser { get; private set; }

        public void Reset()
        {
            Browser = BrowserFactory.ForWebDriver();
        }

        public void OnScenarioFailed(ScenarioFailure context)
        {
            Debug.WriteLine(context.Exception.StackTrace);
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
    }
}
