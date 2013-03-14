namespace StockInquiry.Models.Domain
{
    public class SKU
    {
        public Style Style { get; set; }

        public dynamic Colour { get; set; }

        public dynamic Size { get; set; }

        public dynamic Id { get { return string.Format("{0}{1}{2}", Style.Code, Colour, Size); } }
    }
}
