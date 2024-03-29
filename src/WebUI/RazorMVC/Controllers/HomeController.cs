﻿using Application.Contracts.Persistence;
using Application.DTOs.ErrorDTOs;
using Application.DTOs.GLChartOfAccount;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Accounting.Controllers;

public class HomeController : Controller
{
    private readonly IDbHelpers _dbHelpers;

    public HomeController(IDbHelpers dbHelpers)
    {
        _dbHelpers = dbHelpers;
    }

    public async Task<ActionResult> Index()
    {
        ViewBag.datasource = await _dbHelpers.GetAllAsync<GLChartOfAccountHeadDto>("Select * from GlChartofAccounts");
        return View();
    }
    public ActionResult About()
    {
        ViewBag.Message = "Your application description page.";

        return View();
    }

    public ActionResult Contact()
    {
        ViewBag.Message = "Your contact page.";

        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Lockout()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorDTO { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
