using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceReader.API.Migrations
{
    public partial class updateinvoiceline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceId",
                table: "InvoiceLines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "InvoiceLines");
        }
    }
}
