namespace Excel_Data_Mkaer.Models
{
    public partial class SaleInvoiceTemplate
    {
        public int Id { get; set; }

        public string Date { get; set; }

        public int? CustomerId { get; set; }

        public string SaleInvoiceDescription { get; set; }

        public int ProductId { get; set; }

        public int StockId { get { return 1; } }

        public string UnitTitle { get { return "Number"; } }

        public int Quantity { get; set; }

        public long Fee { get; set; }

        public long Discount { get; set; }
    }
}
