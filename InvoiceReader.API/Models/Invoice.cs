﻿namespace InvoiceReader.API.Models
{
    public class Invoice
    {
        public InvoiceHeader? InvoiceHeader { get; set; }
        public List<InvoiceLine> InvoiceLine { get; set; }

    }
}
