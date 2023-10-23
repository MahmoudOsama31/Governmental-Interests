using GI.Database;
using GI.Models;
using GI.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GI.Controllers
{
    public class OrderMCController : Controller
    {
        private readonly DatabaseContext _db;

        public OrderMCController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult MarriageCertificate()
        {
            ViewBag.governorate3 = new List<string>() { "القاهرة" };
            ViewBag.region = new List<string>() { "مكتب سجل مدني ابو النمرس", "مكتب سجل مدني الازبكية", "مكتب سجل مدني التبين", "مكتب سجل مدني الحوامدية", "مكتب سجل مدني الخليفة", "مكتب سجل مدني الساحل", "مكتب سجل مدني الشيخ زايد", "مكتب سجل مدني العبور", "مكتب سجل مدني العياط", "مكتب سجل مدني القاهرة الجديدة ٣", "مكتب سجل مدني المطرية", "مكتب سجل مدني النزهة", "مكتب سجل مدني امبابة - فرع ١", "مكتب سجل مدني باب الشعرية", "مكتب سجل مدني بولاق الدكرور", "مكتب سجل مدني حلوان - فرع ٢", "مكتب سجل مدني شبرا الخيمة ١", "مكتب سجل مدني طوخ", "مكتب سجل مدني قصر النيل", "مكتب سجل مدني مدينة ٦ اكتوبر" };
            ViewBag.Copies= new List<int>() { 1, 2, 3, 4, 5, 6 };
            ViewBag.DegreeOfKinship = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ViewBag.paymentType = new List<string>() { "CreditCard", "Visa", "MasterCard" };
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarriageCertificate(MarriageCertificateViewModel model)
        {
            if (ModelState.IsValid)
            {
                MarriageCertificate marriage = new MarriageCertificate
                {
                    FullName = model.marriageCertificate.FullName,
                    FirstMotherName = model.marriageCertificate.FirstMotherName,
                    Email=model.marriageCertificate.Email,
                    Address=model.marriageCertificate.Address,
                    CardId=model.marriageCertificate.CardId,
                    FamilyName=model.marriageCertificate.FamilyName,
                    FirstName=model.marriageCertificate.FirstName,
                    FatherName=model.marriageCertificate.FatherName,
                    Governorate=model.marriageCertificate.Governorate,
                    GrandpaName=model.marriageCertificate.GrandpaName,
                    HomePhone=model.marriageCertificate.HomePhone,
                    SecondMotherName=model.marriageCertificate.SecondMotherName,
                    MobilePhone=model.marriageCertificate.MobilePhone,
                    HusbandOrwifeName=model.marriageCertificate.HusbandOrwifeName,
                    NumberOfCopies=model.marriageCertificate.NumberOfCopies,
                    region=model.marriageCertificate.region,
                    Notes=model.marriageCertificate.Notes,
                    PaymentType=model.marriageCertificate.PaymentType,
                    Date = DateTime.Now.ToString("yyy-MM-dd"),
                    OrderType = "وثيقة الجواز",
                };
                await _db.MarriageCertificate.AddAsync(marriage);
                await _db.SaveChangesAsync();
                return RedirectToAction("Payment", "OrderMC", new { id = marriage.MarriageCertificateId });
            }
            ViewBag.governorate3 = new List<string>() { "القاهرة" };
            ViewBag.region = new List<string>() { "مكتب سجل مدني ابو النمرس", "مكتب سجل مدني الازبكية", "مكتب سجل مدني التبين", "مكتب سجل مدني الحوامدية", "مكتب سجل مدني الخليفة", "مكتب سجل مدني الساحل", "مكتب سجل مدني الشيخ زايد", "مكتب سجل مدني العبور", "مكتب سجل مدني العياط", "مكتب سجل مدني القاهرة الجديدة ٣", "مكتب سجل مدني المطرية", "مكتب سجل مدني النزهة", "مكتب سجل مدني امبابة - فرع ١", "مكتب سجل مدني باب الشعرية", "مكتب سجل مدني بولاق الدكرور", "مكتب سجل مدني حلوان - فرع ٢", "مكتب سجل مدني شبرا الخيمة ١", "مكتب سجل مدني طوخ", "مكتب سجل مدني قصر النيل", "مكتب سجل مدني مدينة ٦ اكتوبر" };
            ViewBag.Copies = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ViewBag.paymentType = new List<string>() { "CreditCard", "Visa", "MasterCard" };
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
                var _order2 = await _db.MarriageCertificate.FindAsync(id);
                if (_order2 != null)
                {
                    _order2.IsPaid = true;
                    _db.MarriageCertificate.Update(_order2);
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
            var order = _db.MarriageCertificate.Find(id);
            if (order != null)
            {
                ViewBag.id = order.MarriageCertificateId;
                ViewBag.Date = order.Date;
                ViewBag.ispaid = order.IsPaid;
                ViewBag.confirmed = order.Confirmed;
                ViewBag.orderType = order.OrderType;
                ViewBag.name = order.FullName;
                ViewBag.payment = order.PaymentType;
                ViewBag.address = order.Address;

                if (order.OrderType == "وثيقة الجواز")
                {
                    DateTime dateTime = DateTime.Now;
                    DateTime otherDateTime = dateTime.AddDays(-2);
                    string dateNow = otherDateTime.ToString("yyy-MM-dd");
                    string getDate = order.Date;
                    if (dateNow == getDate)
                    {
                        ViewBag.MC = true;
                    }
                    else
                    {
                        ViewBag.MC = false;
                    }
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult SearchMC(MarriageCertificateViewModel model)
        {
            var order3 = _db.MarriageCertificate.Where(a => a.CardId == model.Search).Select(a => a.MarriageCertificateId).FirstOrDefault();
            if (order3 != null)
            {
                return RedirectToAction("FollowOrder", "OrderMC", new { id = order3 });
            }
            return View();
        }
    }
}
