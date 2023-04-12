using InvoiceReader.API.Controllers;
using InvoiceReader.API.DataAccess;
using InvoiceReader.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceReader.Test
{
    public class InvoiceHeaderControllerTest
    {
        [Fact]
        public async Task GetInvoiceHeaders_ReturnsOkResult_WithListOfInvoiceHeaders()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<DatabaseContext>().UseInMemoryDatabase(databaseName: "TestDatabase").Options;

            var dbContext = new DatabaseContext(options);
            dbContext.InvoiceHeaders.Add(new InvoiceHeader() { Id = 1, InvoiceId = "Invoice 1" });
            dbContext.InvoiceHeaders.Add(new InvoiceHeader() { Id = 2, InvoiceId = "Invoice 2" });
            dbContext.SaveChanges();

            var controller = new InvoiceHeaderController(dbContext);

            // Act
            var result = await controller.GetInvoiceHeaders();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var invoiceHeaders = Assert.IsAssignableFrom<List<InvoiceHeader>>(okResult.Value);
            Assert.Equal(2, invoiceHeaders.Count);
            Assert.Equal("Invoice 1", invoiceHeaders[0].InvoiceId);
            Assert.Equal("Invoice 2", invoiceHeaders[1].InvoiceId);
        }
    }
}
