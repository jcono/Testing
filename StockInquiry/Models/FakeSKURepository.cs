using System.Collections.Generic;
using StockInquiry.Models.Domain;
using StockInquiry.Tests.Data;

namespace StockInquiry.Models
{
    public class FakeSKURepository : IRepository<SKU>
    {
        public IEnumerable<SKU> Find(string styleCode)
        {
            return BenShermans.Shirts.All;
        }
    }
}
