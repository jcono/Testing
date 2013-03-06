using NUnit.Framework;
using Testing.BDD;

namespace Testing.Browser
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
