using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Controllers;
public class GLReportController : Controller
{
    // GET: GLReportsController
    public ActionResult Index()
    {
        return View();
    }

    // GET: GLReportsController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: GLReportsController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: GLReportsController/Create
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

    // GET: GLReportsController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: GLReportsController/Edit/5
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

    // GET: GLReportsController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: GLReportsController/Delete/5
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
