using InvoiceReader.API.DataAccess;
using InvoiceReader.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceHeaderController : Controller
    {
        private readonly DatabaseContext _context;

        public InvoiceHeaderController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<InvoiceHeader>>> GetInvoiceHeaders()
        {
            var invoiceHeaders = await _context.InvoiceHeaders.ToListAsync();
            return Ok(invoiceHeaders);
        }

    }
}
