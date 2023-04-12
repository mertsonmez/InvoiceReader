namespace InvoiceReader.API.Models
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public string InvoiceId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public string UnitCode { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
    }
}
