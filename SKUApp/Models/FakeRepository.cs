using System.Collections.Generic;
using Models.Domain;
using Testing.Data;

namespace SKUApp.Models
{
    public class FakeRepository : IRepository<SKU>
    {
        public IEnumerable<SKU> Find(string key)
        {
            return BenShermans.Shirts.All;
        }
    }
}
