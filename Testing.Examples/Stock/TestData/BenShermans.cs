using System.Collections.Generic;
using Testing.Examples.Stock.Domain;

namespace Testing.Examples.Stock.TestData
{
    internal static class BenShermans
    {
        public static readonly Style MensJeans = new Style
        {
            SKUs = new[]
            {
                new SKU { Colour = "Red", Sizes = new[] { "Small", "Medium", "Large" } }
            }
        };

        public static readonly IEnumerable<Style> EntireRange = new[]
        {
            MensJeans
        };
    }
}