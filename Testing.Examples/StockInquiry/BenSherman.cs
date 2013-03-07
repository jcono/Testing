using System.Collections.Generic;

namespace Testing.Examples.StockInquiry
{
    internal class BenSherman
    {
        public static IEnumerable<Style> EntireRange = null;

        public static Style Shirt = new Style
            {
                StyleCode = "BenShermanShirt",
                SKUs = new[]
                    {
                        new SKU {StyleCode = "BenShermanShirt",  Colour = "White", Size = "Small" },
                        new SKU {StyleCode = "BenShermanShirt", Colour = "White", Size = "Medium" },
                        new SKU {StyleCode = "BenShermanShirt", Colour = "White", Size = "Large" },
                        new SKU {StyleCode = "BenShermanShirt", Colour = "Black", Size = "Small" },
                        new SKU {StyleCode = "BenShermanShirt", Colour = "Black", Size = "Medium" },
                        new SKU {StyleCode = "BenShermanShirt", Colour = "Black", Size = "Large" }
                    }

            };
    }
}