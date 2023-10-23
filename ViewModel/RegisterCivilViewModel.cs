using GI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.ViewModel
{
    public class RegisterCivilViewModel
    {
        public int OrderCivilId { get; set; }

        public string CardID { get; set; }

        [Required(ErrorMessage = "ادخل الاسم بالكامل")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "ادخل الاسم بالكامل")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ادخل البريد الالكتروني")]
        [DataType(DataType.EmailAddress, ErrorMessage = "ادخل البريد الالكتروني بشكل صحيح")]
        [RegularExpression(@"[a-z0-9._%+-]+@gmail.com", ErrorMessage = "ex:a@gmail.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ادخل الهاتف")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "رقم الهاتف 11 رقم")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "ادخل الهاتف بشكل صحيح")]
        public string Phone1 { get; set; }

        [Required(ErrorMessage = "ادخل الهاتف")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "رقم الهاتف 10 ارقام ويبدأ 013")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "ادخل الهاتف بشكل صحيح")]
        public string Phone2 { get; set; }

        [Required(ErrorMessage = "ادخل العنوان")]
        [StringLength(150, MinimumLength = 15, ErrorMessage = "ادخل العنوان بالكامل")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الهاتف بشكل صحيح")]
        public string Address { get; set; }

        [Required(ErrorMessage = "اختر المحافظه")]
        public string governorate { get; set; }

        [Required(ErrorMessage = "اختر المنطقه")]
        public string region { get; set; }

        [Required(ErrorMessage = "اختر نوع البطاقه")]
        public string card_type { get; set; }

        [Required(ErrorMessage = "اختر نوع الخدمه")]
        public string service_type { get; set; }

        [Required(ErrorMessage = "اختر طريقة الدفع")]
        public string payment_method { get; set; }

        [Required(ErrorMessage = "ادخل الصوره الاولي")]
        public IFormFile Photo1 { get; set; }

        [Required(ErrorMessage = "ادخل الصوره الثانيه")]
        public IFormFile Photo2 { get; set; }

        [Display(Name = "الملاحظات")]
        public string Notes { get; set; }
        public bool IsPaid { get; set; }
        public DateTime Date { get; set; }
        public string OrderType { get; set; }
        public bool Confirmed { get; set; }

        [Required(ErrorMessage = "ادخل تاريخ الميلاد")]
        [DataType(DataType.Date, ErrorMessage = "ادخل تاريخ الميلاد بشكل صحيح")]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = "ادخل النوع")]
        public string Kind { get; set; }

        [Required(ErrorMessage = "ادخل الديانه")]
        public string Religion { get; set; }

        [Required(ErrorMessage = "ادخل الحاله الاجتماعيه")]
        public string SocialStatus { get; set; }

        [Required(ErrorMessage = "ادخل المؤهل ")]
        public string qualification { get; set; }
        public string Search { get; set; }
    }
}
