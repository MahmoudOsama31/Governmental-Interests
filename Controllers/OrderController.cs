using GI.Database;
using GI.Models;
using GI.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace GI.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly DatabaseContext _db;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(DatabaseContext db, IHostingEnvironment hosting,UserManager<AppUser> userManager)
        {
            _db = db;
            _hosting = hosting;
            _userManager = userManager;
        }
        [HttpGet]
        public  IActionResult Index(string id)
        {
            ViewBag.region = new List<string>() { "مكتب سجل مدني ابو النمرس", "مكتب سجل مدني الازبكية", "مكتب سجل مدني التبين", "مكتب سجل مدني الحوامدية", "مكتب سجل مدني الخليفة", "مكتب سجل مدني الساحل", "مكتب سجل مدني الشيخ زايد", "مكتب سجل مدني العبور", "مكتب سجل مدني العياط","مكتب سجل مدني القاهرة الجديدة ٣", "مكتب سجل مدني المطرية", "مكتب سجل مدني النزهة", "مكتب سجل مدني امبابة - فرع ١", "مكتب سجل مدني باب الشعرية", "مكتب سجل مدني بولاق الدكرور", "مكتب سجل مدني حلوان - فرع ٢", "مكتب سجل مدني شبرا الخيمة ١", "مكتب سجل مدني طوخ", "مكتب سجل مدني قصر النيل", "مكتب سجل مدني مدينة ٦ اكتوبر" };
            ViewBag.governorate = new List<string>() { "القاهرة" };
            ViewBag.service_type = new List<string>() { "عادية", "سريعة", "VIP" };
            ViewBag.card_type = new List<string>() { "بدل فاقد", "اول مرة", "تحديث بيانات" };
            ViewBag.payment_method = new List<string>() { "CreditCard", "Visa", "MasterCard" };
            ViewBag.kind = new List<string>() {"ذكر","انثي" };
            ViewBag.Religion = new List<string>() { "مسلم", "مسيحي" };
            ViewBag.SocialStatus= new List<string>() { "متزوج", "اعزب" };

            var users = _userManager.FindByIdAsync(id);

            var user = _db.RegisterCivil.Where(a => a.CardID == users.Result.UserName).FirstOrDefault();
            if (user != null)
            {
                ViewBag.Civil = true;
            }
            else
            {
                ViewBag.Civil = false;
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(RegisterCivilViewModel order, string id)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName1 = null;
                string uniqueFileName2 = null;
                byte[] img = null;
                byte[] img2 = null;
                if (order.Photo1 != null)
                {
                    string uploadsFolder = Path.Combine(_hosting.WebRootPath, "Uploads1");
                    uniqueFileName1 = order.Photo1.FileName;
                    string filepath = Path.Combine(uploadsFolder, uniqueFileName1);
                    using (var stream = new MemoryStream())
                    {
                        await order.Photo1.CopyToAsync(stream);
                        img = stream.ToArray();
                    }

                }
                if (order.Photo2 != null)
                {
                    string uploadsFolder = Path.Combine(_hosting.WebRootPath, "Uploads2");
                    uniqueFileName2 = order.Photo2.FileName;
                    string filepath = Path.Combine(uploadsFolder, uniqueFileName2);
                    using (var stream = new MemoryStream())
                    {
                        await order.Photo2.CopyToAsync(stream);
                        img2 = stream.ToArray();
                    }
                }
                var user = await _userManager.FindByIdAsync(id);
                OrderCivilModel orderCivil = new OrderCivilModel
                {
                    Photo1 = img,
                    Photo2 = img2,
                    FullName = order.FullName,
                    Address = order.Address,
                    Email = order.Email,
                    governorate = order.governorate,
                    Notes = order.Notes,
                    region = order.region,
                    payment_method = order.payment_method,
                    Phone1 = order.Phone1,
                    Phone2 = order.Phone2,
                    service_type = order.service_type,
                    card_type = order.card_type,
                    CardID = user.UserName,
                    Date = DateTime.Now.ToString("yyy-MM-dd"),
                    OrderType = "بطاقة الرقم القومي",
                    Kind = order.Kind,
                    qualification= order.qualification,
                    Religion=order.Religion,
                    SocialStatus=order.SocialStatus,
                    BirthDate=order.BirthDate
                };
                await _db.RegisterCivil.AddAsync(orderCivil);
                await _db.SaveChangesAsync();
                return RedirectToAction("Payment", "Order", new { id = orderCivil.OrderCivilId });
            }
            ModelState.AddModelError("", "Invalid inputs");
            ViewBag.region = new List<string>() { "مكتب سجل مدني ابو النمرس", "مكتب سجل مدني الازبكية", "مكتب سجل مدني التبين", "مكتب سجل مدني الحوامدية", "مكتب سجل مدني الخليفة", "مكتب سجل مدني الساحل", "مكتب سجل مدني الشيخ زايد", "مكتب سجل مدني العبور", "مكتب سجل مدني العياط", "مكتب سجل مدني القاهرة الجديدة ٣", "مكتب سجل مدني المطرية", "مكتب سجل مدني النزهة", "مكتب سجل مدني امبابة - فرع ١", "مكتب سجل مدني باب الشعرية", "مكتب سجل مدني بولاق الدكرور", "مكتب سجل مدني حلوان - فرع ٢", "مكتب سجل مدني شبرا الخيمة ١", "مكتب سجل مدني طوخ", "مكتب سجل مدني قصر النيل", "مكتب سجل مدني مدينة ٦ اكتوبر" };
            ViewBag.governorate = new List<string>() { "القاهرة"};
            ViewBag.service_type = new List<string>() { "عادية", "سريعة", "VIP" };
            ViewBag.card_type = new List<string>() { "بدل فاقد", "اول مرة", "تحديث بيانات" };
            ViewBag.payment_method = new List<string>() { "CreditCard", "Visa", "MasterCard" };
            ViewBag.kind = new List<string>() { "ذكر", "انثي" };
            ViewBag.Religion = new List<string>() { "مسلم", "مسيحي" };
            ViewBag.SocialStatus = new List<string>() { "متزوج", "اعزب" };
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
                var _order = await _db.RegisterCivil.FindAsync(id);
                if (_order != null)
                {
                    _order.IsPaid = true;
                    _db.RegisterCivil.Update(_order);
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
            var order = _db.RegisterCivil.Find(id);
            if (order!=null)
            {
                ViewBag.id = order.OrderCivilId;
                ViewBag.Date = order.Date;
                ViewBag.ispaid = order.IsPaid;
                ViewBag.confirmed = order.Confirmed;
                ViewBag.serviceType = order.service_type;
                ViewBag.photo = order.Photo1;
                ViewBag.name = order.FullName;
                ViewBag.payment = order.payment_method;
                ViewBag.address = order.Address;
                ViewBag.order = order.OrderType;

                int getDay = Convert.ToInt32(order.Date.Split('-').Last());
                int getYear = Convert.ToInt32(order.Date.Split('-').First());
                int getMonth = Convert.ToInt32(order.Date.Substring(5, 2));

                int getDayNow = Convert.ToInt32(DateTime.Now.ToString("yyy-MM-dd").Split('-').Last());
                int getYearNow = Convert.ToInt32(DateTime.Now.ToString("yyy-MM-dd").Split('-').First());
                int getMonthNow = Convert.ToInt32(DateTime.Now.ToString("yyy-MM-dd").Substring(5, 2));
                System.DateTime firstDate = new System.DateTime(getYear, getMonth, getDay);
                System.DateTime secondDate = new System.DateTime(getYearNow, getMonthNow, getDayNow);

                System.TimeSpan diff = secondDate.Subtract(firstDate);
                System.TimeSpan diff1 = secondDate - firstDate;

                String diff2 = (secondDate - firstDate).TotalDays.ToString();
                int getDiff2 = Convert.ToInt32(diff2);
                Console.WriteLine(diff2);

                if (order.service_type == "VIP")
                {
                    if (getDiff2 == 1)
                    {
                        ViewBag.vip = true;
                    }
                    else
                    {
                        ViewBag.vip = false;
                    }
                }
                else if (order.service_type == "سريعة")
                {
                    if (getDiff2 >= 2 && getDiff2 < 4)
                    {
                        ViewBag.quick = true;
                    }
                    else
                    {
                        ViewBag.quick = false;
                    }
                }
                else
                {
                    if (getDiff2 >= 4 && getDiff2 < 8)
                    {
                        ViewBag.normal = true;
                    }
                    else
                    {
                        ViewBag.normal = false;
                    }

                }
                ViewBag.Follow_Order = 0;
            }
            else
            {
                ViewBag.Follow_Order = 1;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Search(RegisterCivilViewModel model,string id)
        {
            var users = _userManager.FindByIdAsync(id);
            var order1 = _db.RegisterCivil.Where(a => a.CardID == model.Search).Select(a => a.OrderCivilId).FirstOrDefault();
            if (order1 != null)
            {
                return RedirectToAction("FollowOrder", "Order", new { id = order1 });
            }

            return View();
        }
    }
}
