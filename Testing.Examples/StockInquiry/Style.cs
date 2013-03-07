using System.Collections.Generic;

namespace Testing.Examples.StockInquiry
{
    internal class Style
    {
        public IEnumerable<SKU> SKUs;
        public string StyleCode { get; set; }
    }

    internal class SKU
    {
        public string StyleCode { get; set; }

        public string Colour { get; set; }

        public string Size { get; set; }
    }
}