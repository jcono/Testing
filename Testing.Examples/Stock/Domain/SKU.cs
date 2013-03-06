using System.Collections.Generic;

namespace Testing.Examples.Stock.Domain
{
    internal class SKU
    {
        public string Colour { get; set; }

        public IEnumerable<string> Sizes { get; set; }
    }
}