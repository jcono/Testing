using NUnit.Framework;
using Testing.Framework.BDD;

namespace Testing.Framework.Browser
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
