using InvoiceReader.API.DataAccess;
using InvoiceReader.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public InvoiceController(DatabaseContext context)
        {
            _context = context;
        }
       
        [HttpPost]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var invoiceHeader = new InvoiceHeader()
            {
                InvoiceId = invoice.InvoiceHeader.InvoiceId,
                SenderTitle = invoice.InvoiceHeader.SenderTitle,
                ReceiverTitle = invoice.InvoiceHeader.ReceiverTitle,
                Date = invoice.InvoiceHeader.Date
            };

            var invoiceLines = invoice.InvoiceLine.Select(il => new InvoiceLine
            {
                Name = il.Name,
                Quantity = il.Quantity,
                UnitCode = il.UnitCode,
                UnitPrice = il.UnitPrice,
                InvoiceId = invoice.InvoiceHeader.InvoiceId
            }).ToList();

            _context.InvoiceHeaders.Add(invoiceHeader);

            foreach (var item in invoiceLines)
            {
                _context.InvoiceLines.Add(item);
            }            
            
            await _context.SaveChangesAsync();

            return Ok(invoice);
        }
    }
}

