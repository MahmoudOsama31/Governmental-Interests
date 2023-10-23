using GI.Database;
using GI.Models;
using GI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GI.Controllers
{
    [Authorize]
    public class OrderBCController : Controller
    {
        private readonly DatabaseContext _db;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<AppUser> _userManager;

        public OrderBCController(DatabaseContext db, IHostingEnvironment hosting, UserManager<AppUser> userManager)
        {
            _db = db;
            _hosting = hosting;
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult BirthCertificate(string id)
        {
            ViewBag.governorate2 = new List<string>() { "القاهرة" };
            ViewBag.PoliceDepartment = new List<string>() { "قسم شرطة حلوان" };
            ViewBag.Copies = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ViewBag.DegreeOfKinship = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ViewBag.paymentType = new List<string>() { "CreditCard", "Visa", "MasterCard" };
            ViewBag.kind = new List<string>() { "ذكر", "انثي" };
            ViewBag.Religion = new List<string>() { "مسلم", "مسيحي" };

            var users = _userManager.FindByIdAsync(id);

            var user = _db.Birthcertificates.Where(a => a.CardLoginID == users.Result.UserName).FirstOrDefault();
            if (user != null)
            {
                ViewBag.Certi = true;
            }
            else
            {
                ViewBag.Certi = false;
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BirthCertificate(BirthcertificateViewModel model, string id)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName1 = null;
                string uniqueFileName2 = null;
                byte[] img = null;
                byte[] img2 = null;
                if (model.photo1 != null)
                {
                    string uploadsFolder = Path.Combine(_hosting.WebRootPath, "UploadCertificate1");
                    uniqueFileName1 = model.photo1.FileName;
                    string filepath = Path.Combine(uploadsFolder, uniqueFileName1);
                    using (var stream = new MemoryStream())
                    {
                        await model.photo1.CopyToAsync(stream);
                        img = stream.ToArray();
                    }

                }
                if (model.photo2 != null)
                {
                    string uploadsFolder = Path.Combine(_hosting.WebRootPath, "UploadCertificate2");
                    uniqueFileName2 = model.photo2.FileName;
                    string filepath = Path.Combine(uploadsFolder, uniqueFileName2);
                    using (var stream = new MemoryStream())
                    {
                        await model.photo2.CopyToAsync(stream);
                        img2 = stream.ToArray();
                    }
                }
                var user = await _userManager.FindByIdAsync(id);
                Birthcertificate birthcertificate = new Birthcertificate
                {
                    photo1 = img,
                    photo2 = img2,
                    FullName = model.birthcertificate.FullName,
                    Email = model.birthcertificate.Email,
                    Address = model.birthcertificate.Address,
                    CardId = model.birthcertificate.CardId,
                    DegreeOfKinship = model.birthcertificate.DegreeOfKinship,
                    FirstName = model.birthcertificate.FirstName,
                    FatherName = model.birthcertificate.FatherName,
                    FamilyName = model.birthcertificate.FamilyName,
                    Governorate = model.birthcertificate.Governorate,
                    MobilePhone = model.birthcertificate.MobilePhone,
                    GrandpaName = model.birthcertificate.GrandpaName,
                    HomePhone = model.birthcertificate.HomePhone,
                    MotherName = model.birthcertificate.MotherName,
                    Notes = model.birthcertificate.Notes,
                    NumberOfCopies = model.birthcertificate.NumberOfCopies,
                    PaymentType = model.birthcertificate.PaymentType,
                    Date = DateTime.Now.ToString("yyy-MM-dd"),
                    OrderType = "شهادة الميلاد",
                    Kind = model.birthcertificate.Kind,
                    Religion = model.birthcertificate.Religion,
                    BirthDate = model.birthcertificate.BirthDate,
                    CardLoginID = user.UserName
                };
                await _db.Birthcertificates.AddAsync(birthcertificate);
                await _db.SaveChangesAsync();
                return RedirectToAction("Payment", "OrderBC", new { id = birthcertificate.BirthcertificateId });
            }
            ViewBag.governorate2 = new List<string>() { "القاهرة" };
            ViewBag.PoliceDepartment = new List<string>() { "قسم شرطة حلوان" };
            ViewBag.Copies = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ViewBag.DegreeOfKinship = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ViewBag.paymentType = new List<string>() { "CreditCard", "Visa", "MasterCard" };
            ViewBag.kind = new List<string>() { "ذكر", "انثي" };
            ViewBag.Religion = new List<string>() { "مسلم", "مسيحي" };
            return View();
        }

        [HttpGet]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Payment(int id)
        {
            if (ModelState.IsValid)
            {
                var _order2 = await _db.Birthcertificates.FindAsync(id);
                if (_order2 != null)
                {
                    _order2.IsPaid = true;
                    _db.Birthcertificates.Update(_order2);
                    _db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "خطأ في الادخال برجاء التأكد من ادخال كل البيانات");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult FollowOrder(int id)
        {
            var order = _db.Birthcertificates.Find(id);
            if (order != null)
            {
                ViewBag.id1 = order.BirthcertificateId;
                ViewBag.Date1 = order.Date;
                ViewBag.ispaid1 = order.IsPaid;
                ViewBag.confirmed1 = order.Confirmed;
                ViewBag.serviceType1 = order.OrderType;
                ViewBag.name1 = order.FullName;
                ViewBag.payment1 = order.PaymentType;
                ViewBag.address1 = order.Address;
                ViewBag.aaa = order.NumberOfCopies;

                if (order.OrderType == "شهادة الميلاد")
                {
                    DateTime dateTime = DateTime.Now;
                    DateTime otherDateTime = dateTime.AddDays(-2);
                    string dateNow = otherDateTime.ToString("yyy-MM-dd");
                    string getDate = order.Date;
                    if (dateNow == getDate)
                    {
                        ViewBag.a = true;
                    }
                    else
                    {
                        ViewBag.a = false;
                    }
                }
                ViewBag.Follow = 0;
            }
            else
            {
                ViewBag.Follow = 1;
            }
            return View();
        }

        [HttpPost]
        public IActionResult SearchBC(BirthcertificateViewModel model)
        {
            var order2 = _db.Birthcertificates.Where(a => a.CardId == model.Search).Select(a => a.BirthcertificateId).FirstOrDefault();
            if (order2 != null)
            {
                return RedirectToAction("FollowOrder", "OrderBC", new { id = order2 });
            }
            return View();
        }

    }
}

