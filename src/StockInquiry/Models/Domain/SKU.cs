namespace StockInquiry.Models.Domain
{
    public class SKU
    {
        public Style Style { get; set; }

        public string Colour { get; set; }

        public string Size { get; set; }

        public string Id => $"{Style.Code}{Colour}{Size}";
    }
}
