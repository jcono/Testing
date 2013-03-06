using System;
using System.Linq;
using NUnit.Framework;
using Testing.Browser;
using Testing.Examples.Google.Model.Pages;

namespace Testing.Examples.Google.Test
{
    public class SearchExampleTestContext : BrowserTestContext
    {
        public void AmVisitingGoogle()
        {
            Launch("http://www.google.com");
        }

        public Action SearchFor(string searchTerm)
        {
            return () => On<HomePage>().SearchFor(searchTerm);
        }

        public Action FindAResultFor(string something)
        {
            return () => Assert.That(On<HomePage>().Results.Any(r => r.Title.Contains(something)), Is.True);
        }
    }
}
