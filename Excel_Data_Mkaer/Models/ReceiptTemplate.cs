using System;

namespace Excel_Data_Mkaer.Models
{
    public partial class ReceiptTemplate
    {
        public int Id { get; set; }

        public int ReceiptType { get { return 1; } }

        public int CustomerId { get; set; }

        public DateTime ReceiptDate { get; set; }

        public long CashAmount { get; set; }

        public string ReceiptDescription { get; set; }

        public bool ReceiptDateType { get; set; }
    }
}
