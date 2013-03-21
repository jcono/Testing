using System;
using System.Collections.Generic;
using StockInquiry.Models.Domain;
using System.Linq;

namespace StockInquiry.Tests.Data
{
    public static class Styles
    {
        public static readonly Style BenShermanShirt = new Style { Code = "BenShermanShirt" };

        private static Dictionary<string, Style> _descriptionLookup = new Dictionary<string, Style>
        {
            { "Ben Sherman Shirt", BenShermanShirt }
        }; 

        public static string FindCodeFor(string description)
        {
            return _descriptionLookup[description].Code;
        }
    }

    public static class BenSherman
    {
        public static class Shirt
        {
            private const string Black = "Black";
            private const string White = "White";
            private const string Small = "Small";
            private const string Medium = "Medium";
            private const string Large = "Large";

            public static readonly SKU InSmallWhite = new SKU { Style = Styles.BenShermanShirt, Colour = White, Size = Small };
            public static readonly SKU InMediumWhite = new SKU { Style = Styles.BenShermanShirt, Colour = White, Size = Medium };
            public static readonly SKU InLargeWhite = new SKU { Style = Styles.BenShermanShirt, Colour = White, Size = Large };
            public static readonly SKU InSmallBlack = new SKU { Style = Styles.BenShermanShirt, Colour = Black, Size = Small };
            public static readonly SKU InMediumBlack = new SKU { Style = Styles.BenShermanShirt, Colour = Black, Size = Medium };
            public static readonly SKU InLargeBlack = new SKU { Style = Styles.BenShermanShirt, Colour = Black, Size = Large };

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
