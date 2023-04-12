using InvoiceReader.API.DataAccess;
using InvoiceReader.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceLineController : Controller
    {
        private readonly DatabaseContext _context;

        public InvoiceLineController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<InvoiceLine>>> GetInvoiceLines(string invoiceId)
        {
            var invoiceLines = await _context.InvoiceLines.Where(w=>w.InvoiceId == invoiceId).ToListAsync();
            return Ok(invoiceLines);
        }        

    }
}
