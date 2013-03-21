using System.Collections.Generic;
using StockInquiry.Models.Domain;

namespace StockInquiry.Tests.Data
{
    public static class BenSherman
    {
        public static class Shirt
        {
            public static readonly Style Style = new Style { Code = "BenShermanShirt" };

            private const string Black = "Black";
            private const string White = "White";
            private const string Small = "Small";
            private const string Medium = "Medium";
            private const string Large = "Large";

            public static readonly SKU InSmallWhite = new SKU { Style = Style, Colour = White, Size = Small };
            public static readonly SKU InMediumWhite = new SKU { Style = Style, Colour = White, Size = Medium };
            public static readonly SKU InLargeWhite = new SKU { Style = Style, Colour = White, Size = Large };
            public static readonly SKU InSmallBlack = new SKU { Style = Style, Colour = Black, Size = Small };
            public static readonly SKU InMediumBlack = new SKU { Style = Style, Colour = Black, Size = Medium };
            public static readonly SKU InLargeBlack = new SKU { Style = Style, Colour = Black, Size = Large };

            public static readonly IEnumerable<SKU> All = new[]
            {
                InSmallWhite,
                InMediumWhite,
                InLargeWhite,
                InSmallBlack,
                InMediumBlack,
                InLargeBlack
            };
        }

        public class Scarf
        {
            public static readonly Style Style = new Style { Code = "BenShermanScarf" };

            public static readonly SKU InRed = new SKU { Style = Style, Colour = Colour.Red };
            public static readonly SKU InBlue = new SKU { Style = Style, Colour = Colour.Blue };
            public static readonly SKU InGreen = new SKU { Style = Style, Colour = Colour.Green };

            public static readonly IEnumerable<SKU> All = new[]
            {
                InRed,
                InBlue,
                InGreen
            };
        }

        public static IEnumerable<SKU> EntireRange
        {
            get
            {
                var range = new List<SKU>();
                range.AddRange(Shirt.All);
                range.AddRange(Scarf.All);
                return range;
            }
        }

        public static class StockOf
        {
            public class Shirts
            {
                public static readonly IEnumerable<Stock> MediumBlackShirts = new[]
                {
                    new Stock { SKU = Shirt.InMediumBlack, Location = Locations.Doncaster, Quantity = 5 },
                    new Stock { SKU = Shirt.InMediumBlack, Location = Locations.Chadstone, Quantity = 2 }
                };
            }
        }
    }
}
