﻿using System.Collections.Generic;
using Models.Domain;

namespace Testing.Data
{
    public static class BenShermans
    {
        public static readonly IEnumerable<Style> EntireRange = null;

        public static readonly Style Shirt = new Style
        {
            StyleCode = "BenShermanShirt",
            SKUs = new[]
            {
                new SKU { StyleCode = "BenShermanShirt", Colour = "White", Size = "Small" },
                new SKU { StyleCode = "BenShermanShirt", Colour = "White", Size = "Medium" },
                new SKU { StyleCode = "BenShermanShirt", Colour = "White", Size = "Large" },
                new SKU { StyleCode = "BenShermanShirt", Colour = "Black", Size = "Small" },
                new SKU { StyleCode = "BenShermanShirt", Colour = "Black", Size = "Medium" },
                new SKU { StyleCode = "BenShermanShirt", Colour = "Black", Size = "Large" }
            }
        };
    }
}
