using System.Collections.Generic;

namespace Models.Domain
{
    public class Style
    {
        public IEnumerable<SKU> SKUs;
        public string StyleCode { get; set; }
    }
}
