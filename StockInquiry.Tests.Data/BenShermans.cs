using System.Collections.Generic;
using StockInquiry.Models.Domain;

namespace StockInquiry.Tests.Data
{
    public static class BenShermans
    {
        public static class Shirts
        {
            public static readonly Style Style = new Style { Code = "BenShermanShirt" };

            private const string Black = "Black";
            private const string White = "White";
            private const string Small = "Small";
            private const string Medium = "Medium";
            private const string Large = "Large";

            public static readonly SKU SmallWhite = new SKU { Style = Style, Colour = White, Size = Small };
            public static readonly SKU MediumWhite = new SKU { Style = Style, Colour = White, Size = Medium };
            public static readonly SKU LargeWhite = new SKU { Style = Style, Colour = White, Size = Large };
            public static readonly SKU SmallBlack = new SKU { Style = Style, Colour = Black, Size = Small };
            public static readonly SKU InMediumBlack = new SKU { Style = Style, Colour = Black, Size = Medium };
            public static readonly SKU LargeBlack = new SKU { Style = Style, Colour = Black, Size = Large };

            public static readonly IEnumerable<SKU> All = new[]
            {
                SmallWhite,
                MediumWhite,
                LargeWhite,
                SmallBlack,
                InMediumBlack,
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

        public const string Doncaster = "Doncaster";
        public const string Chadstone = "Chadstone";

        public static readonly IEnumerable<Stock> MediumBlackShirtStock = new[]
        {
            new Stock { SKU = Shirts.InMediumBlack, Location = Doncaster, Quantity = 5 },
            new Stock { SKU = Shirts.InMediumBlack, Location = Chadstone, Quantity = 2 }
        };
    }
}
