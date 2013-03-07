using System.Collections.Generic;

namespace SKUApp.Models
{
    public class FakeRepository : IRepository<SKU>
    {
        private readonly List<SKU> _expectedModel;

        public IEnumerable<SKU> Find(string key)
        {
            return new[]
                {
                    new SKU {StyleCode = "BenShermanShirt", Colour = "White", Size = "Small"},
                    new SKU {StyleCode = "BenShermanShirt", Colour = "White", Size = "Medium"},
                    new SKU {StyleCode = "BenShermanShirt", Colour = "White", Size = "Large"},
                    new SKU {StyleCode = "BenShermanShirt", Colour = "Black", Size = "Small"},
                    new SKU {StyleCode = "BenShermanShirt", Colour = "Black", Size = "Medium"},
                    new SKU {StyleCode = "BenShermanShirt", Colour = "Black", Size = "Large"}
                };

        }
    }
}