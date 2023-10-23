using GI.Database;
using GI.Models;
using GI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace GI.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _db;
        public HomeController(DatabaseContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Serves = new List<string>() { "بطاقة الرقم القومي", "شهادة الميلاد"};
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Index(HomeViewModel model)
        {

            if (ModelState.IsValid)
            {
                ContactUs newContact = new ContactUs
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Message = model.Message,
                    Serves = model.Serves
                };
                await _db.AddAsync(newContact);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Invalid inputs");
            ViewBag.Serves = new List<string>() { "بطاقة الرقم القومي", "شهادة الميلاد" };
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
