using System.Collections.Generic;

namespace StockInquiry.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> Find(string key);
    }
}
