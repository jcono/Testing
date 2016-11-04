using NUnit.Framework;
using StockInquiry.Tests.Framework.BDD;

namespace StockInquiry.Tests.Framework.Browser
{
    public class BrowserTest<T> : BehaviourDrivenTest<T> where T : BrowserTestContext, new()
    {
        [SetUp]
        public void BrowserReset()
        {
            I.Reset();
        }
    }
}
