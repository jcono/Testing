using System.Collections.Generic;
using StockInquiry.Models.Domain;
using StockInquiry.Tests.Data;

namespace StockInquiry.Models
{
    public class FakeStockRepository : IRepository<Stock>
    {
        public IEnumerable<Stock> Find(string skuId)
        {
            return BenSherman.StockOf.Shirts.MediumBlackShirts;
        }
    }
}