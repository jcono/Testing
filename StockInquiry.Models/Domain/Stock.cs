namespace StockInquiry.Models.Domain
{
    public class Stock
    {
        public SKU SKU { get; set; }

        public dynamic Location { get; set; }

        public int Quantity { get; set; }
    }
}
