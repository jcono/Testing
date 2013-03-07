using System.Collections.Generic;
using Models.Domain;
using Testing.Data;

namespace SKUApp.Models
{
    public class FakeRepository : IRepository<SKU>
    {
        private readonly List<SKU> _expectedModel;

        public IEnumerable<SKU> Find(string key)
        {
            return BenShermans.Shirt.SKUs;
        }
    }
}
