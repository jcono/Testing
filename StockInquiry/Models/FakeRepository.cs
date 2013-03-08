using System.Collections.Generic;
using StockInquiry.Models.Domain;
using StockInquiry.Tests.Data;

namespace StockInquiry.Models
{
    public class FakeRepository : IRepository<SKU>
    {
        public IEnumerable<SKU> Find(string key)
        {
            return BenShermans.Shirts.All;
        }
    }
}
