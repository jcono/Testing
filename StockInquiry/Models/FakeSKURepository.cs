using System.Collections.Generic;
using System.Linq;
using StockInquiry.Models.Domain;
using StockInquiry.Tests.Data;

namespace StockInquiry.Models
{
    public class FakeSKURepository : IRepository<SKU>
    {
        public IEnumerable<SKU> Find(string styleCode)
        {
            return BenSherman.EntireRange.Where(x => x.Style.Code == styleCode);
        }
    }
}
