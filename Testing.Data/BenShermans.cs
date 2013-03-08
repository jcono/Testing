using System.Collections.Generic;
using Models.Domain;

namespace Testing.Data
{
    public static class BenShermans
    {
        public static readonly Style Shirt = new Style { Code = "BenShermanShirt" };

        public static class Shirts
        {
            private const string Black = "Black";
            private const string White = "White";
            private const string Small = "Small";
            private const string Medium = "Medium";
            private const string Large = "Large";

            public static readonly SKU SmallWhite = new SKU { Style = Shirt, Colour = White, Size = Small };
            public static readonly SKU MediumWhite = new SKU { Style = Shirt, Colour = White, Size = Medium };
            public static readonly SKU LargeWhite = new SKU { Style = Shirt, Colour = White, Size = Large };
            public static readonly SKU SmallBlack = new SKU { Style = Shirt, Colour = Black, Size = Small };
            public static readonly SKU MediumBlack = new SKU { Style = Shirt, Colour = Black, Size = Medium };
            public static readonly SKU LargeBlack = new SKU { Style = Shirt, Colour = Black, Size = Large };

            public static readonly IEnumerable<SKU> All = new[]
            {
                SmallWhite,
                MediumWhite,
                LargeWhite,
                SmallBlack,
                MediumBlack,
                LargeBlack
            };
        }

        public static IEnumerable<SKU> EntireRange
        {
            get
            {
                var range = new List<SKU>();
                range.AddRange(Shirts.All);
                return range;
            }
        }

        public static IEnumerable<Stock> MediumBlackShirtStock { get; private set; }
    }
}
