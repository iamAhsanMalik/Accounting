using Application.Contracts.Persistence;
using Application.DTOs.Invoice;
using Microsoft.AspNetCore.Mvc;
using Persistence.Helpers;

namespace Accounting.Controllers;
public class InvoiceController : Controller
{
    private readonly IDbHelpers _dbHelpers;

    public InvoiceController(IDbHelpers dbHelpers)
    {
        _dbHelpers = dbHelpers;
    }

    public ActionResult Index()
    {
        //var result = await _dbHelpers.PopulateDropDownAsync("select (CustomerFirstName +' '+ CustomerLastName) Text, (CustomerFirstName +' '+ CustomerLastName) as Value from Customers");
        return View();
    }
    public ActionResult AddInvoice()
    {
        //var result = await _dbHelpers.PopulateDropDownAsync("select (CustomerFirstName +' '+ CustomerLastName) Text, (CustomerFirstName +' '+ CustomerLastName) as Value from Customers");
        return View();
    }
    [HttpPost]
    public async Task<ActionResult> AddInvoice(AddInvoiceDto addInvoiceDto)
    {
        //var insertCustomerStatus = await dbHelpers.InsertOneAsync("Insert into Customers (CustomerFirstName, CustomerLastName, CustomerEmail, CustomerAddress1,CustomerCellPhone ,Status) Values(@CustomerFirstName, @CustomerLastName, @CustomerEmail, @CustomerAddress1,@CustomerCellPhone ,@Status)", new CustomersDto { CustomerFirstName = customersDto.CustomerFirstName, CustomerLastName = customersDto.CustomerLastName, CustomerEmail = customersDto.CustomerEmail, CustomerAddress1 = customersDto.CustomerAddress1, CustomerCellPhone = customersDto.CustomerCellPhone, Status = customersDto.Status });
        return View("~/Views/Reports/Accounts/InvoiceGenerator.cshtml", addInvoiceDto);
    }
}
