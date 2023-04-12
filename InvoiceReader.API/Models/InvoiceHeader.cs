namespace InvoiceReader.API.Models
{
    public class InvoiceHeader
    {
        public int Id { get; set; }
        public string InvoiceId { get; set; } = string.Empty;
        public string SenderTitle { get; set; } = string.Empty;
        public string ReceiverTitle { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
