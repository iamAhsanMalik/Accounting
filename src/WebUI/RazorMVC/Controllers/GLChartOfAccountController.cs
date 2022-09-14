using Application.Contracts.Identity;
using Application.Contracts.Persistence;
using Application.DTOs.GLChartOfAccount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Accounting.Controllers;
public class GLChartOfAccountController : Controller
{
    private readonly IDbHelpers _dbHelpers;
    private readonly IUserInfo _userInfo;

    public GLChartOfAccountController(IDbHelpers dbHelpers, IUserInfo userInfo)
    {
        _dbHelpers = dbHelpers;
        _userInfo = userInfo;
    }

    // GET: GLChartOfAccountController
    public ActionResult Index()
    {
        return View();
    }

    // GET: GLChartOfAccountController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: GLChartOfAccountController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: GLChartOfAccountController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: GLChartOfAccountController/Create
    public async Task<ActionResult> ChildAccount()
    {
        ViewBag.AccountHeads = await _dbHelpers.PopulateDropDownAsync("Select AccountName as Text, AccountCode as Value from GlChartOfAccounts where IsHead = 1", "Select Account Head","","","DHA_AccountingSystem");
        return View();
    }

    // POST: GLChartOfAccountController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> ChildAccount(GLChartOfAccountChildDto model)
    {
        try
        {
            var currentLoginUserName = await _userInfo.GetCurrentLoginUserUserNameAsync();
            var result = await _dbHelpers.InsertOneByStoreProcedureAsync<object>("SP_InsertGLChartOfAccountChild", new { ParentAccountCode = model.ParentAccountCode, AccountName = model.AccountName, AccountStatus = model.AccountStatus, AddedBy = currentLoginUserName, AddedDate = DateTime.Now, LastModifyBy = currentLoginUserName, LastModifyDate = DateTime.Now }, "DHA_AccountingSystem");

            return RedirectToAction(nameof(ChildAccount));
        }
        catch
        {
            return View();
        }
    }

    // GET: GLChartOfAccountController/Create
    public ActionResult HeadAccount()
    {
        return View();
    }

    // POST: GLChartOfAccountController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> HeadAccount(GLChartOfAccountHeadDto model)
    {
        try
        {
            var currentLoginUserName = await _userInfo.GetCurrentLoginUserUserNameAsync();
            var result = await _dbHelpers.InsertOneByStoreProcedureAsync<object>("SP_InsertGLChartOfAccountHead", new { AccountName = model.AccountName, DebiteLimit = model.DebiteLimit, CreditLimit = model.CreditLimit, AccountStatus = model.AccountStatus, AddedBy = currentLoginUserName, AddedDate = DateTime.Now, LastModifyBy = currentLoginUserName, LastModifyDate = DateTime.Now }, "DHA_AccountingSystem");

            return RedirectToAction(nameof(HeadAccount));
        }
        catch
        {
            return View();
        }
    }

    // GET: GLChartOfAccountController/Create
    public ActionResult AccountSetting()
    {
        return View();
    }

    // POST: GLChartOfAccountController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult AccountSetting(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: GLChartOfAccountController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: GLChartOfAccountController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: GLChartOfAccountController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: GLChartOfAccountController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
