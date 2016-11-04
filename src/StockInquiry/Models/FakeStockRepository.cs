using System.Collections.Generic;
using StockInquiry.Models.Data;
using StockInquiry.Models.Domain;

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
