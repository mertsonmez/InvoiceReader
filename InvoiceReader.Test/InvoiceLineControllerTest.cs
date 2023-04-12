using InvoiceReader.API.Controllers;
using InvoiceReader.API.DataAccess;
using InvoiceReader.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceReader.Test
{
    public class InvoiceLineControllerTest
    {
        [Fact]
        public async Task GetInvoiceLines_ReturnsOkResult_WithListOfInvoiceLines()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            var dbContext = new DatabaseContext(options);
            dbContext.InvoiceLines.Add(new InvoiceLine() { Id = 1, InvoiceId = "INV001", Name = "Laptop" });
            dbContext.InvoiceLines.Add(new InvoiceLine() { Id = 2, InvoiceId = "INV002", Name = "Book" });
            dbContext.InvoiceLines.Add(new InvoiceLine() { Id = 3, InvoiceId = "INV003", Name = "Phone" });
            dbContext.SaveChanges();

            var controller = new InvoiceLineController(dbContext);

            // Act
            var result = await controller.GetInvoiceLines("INV001");

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var invoiceLines = Assert.IsAssignableFrom<List<InvoiceLine>>(okResult.Value);
            Assert.Single(invoiceLines);
            Assert.Equal("Laptop", invoiceLines[0].Name);
        }
    }
}
