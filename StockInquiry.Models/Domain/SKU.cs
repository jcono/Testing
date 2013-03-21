namespace StockInquiry.Models.Domain
{
    public class SKU
    {
        public Style Style { get; set; }

        public string Colour { get; set; }

        public string Size { get; set; }

        public string Id { get { return string.Format("{0}{1}{2}", Style.Code, Colour, Size); } }
    }
}
