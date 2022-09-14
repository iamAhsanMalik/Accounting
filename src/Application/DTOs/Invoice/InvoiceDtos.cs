using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Invoice;
public class InvoiceDtos
{

}

public class AddInvoiceDto
{
    public string? CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
    public string? BillingAddress { get; set; }
    public string? PaymentTerms { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public string? ShippingTo { get; set; }
    public string? ShippingVia { get; set; }
    public DateTime ShippingDate { get; set; }
    public string? TrackingNumber { get; set; }
    public string? InvoiceNumber { get; set; }
    public string? Location { get; set; }
    public List<InvoiceItemDto> InvoiceItems { get; set; } = new List<InvoiceItemDto>();
    public string? MessageOnInvoice { get; set; } // Message On Invoice
    public string? MessageOnStatement { get; set; } // Message On Statement
    public string? Attachments { get; set; }
}

public class InvoiceItemDto
{
    public DateTime ServiceDate { get; set; }
    public string? ProductOrService { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public decimal Rate { get; set; }
    public decimal Amount { get; set; }
    public string? Tax { get; set; }
    public string? Class { get; set; }
}