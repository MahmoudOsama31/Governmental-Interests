using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace GI.Models
{
    public class Birthcertificate
    {
        public int BirthcertificateId { get; set; }
        public string CardLoginID { get; set; }

        [Required(ErrorMessage = "ادخل الاسم بالكامل")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "ادخل الاسم بالكامل")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ادخل اسم الام")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string MotherName { get; set; }

        [Required(ErrorMessage = "ادخل البريد الالكتروني")]
        [DataType(DataType.EmailAddress, ErrorMessage = "ادخل البريد الالكتروني بشكل صحيح")]
        [RegularExpression(@"[a-z0-9._%+-]+@gmail.com", ErrorMessage = "ex:a@gmail.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ادخل الهاتف")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "رقم الهاتف 11 رقم")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "ادخل الهاتف بشكل صحيح")]
        public string MobilePhone { get; set; }

        [Required(ErrorMessage = "ادخل الهاتف")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "رقم الهاتف 10 رقم يبدأ 013")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "ادخل الهاتف بشكل صحيح")]
        public string HomePhone { get; set; }

        [Required(ErrorMessage = "اختر المحافظه")]
        public string Governorate { get; set; }

        [Required(ErrorMessage = "اختر عدد النسخ")]
        public int NumberOfCopies { get; set; }

        [Required(ErrorMessage = "اختر درجة القرابة لمقدم الطلب")]
        public int DegreeOfKinship { get; set; }

        [Required(ErrorMessage = "ادخل الاسم الاول")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "ادخل اسم الاب")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "ادخل اسم الجد")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string GrandpaName { get; set; }

        [Required(ErrorMessage = "ادخل اسم العائله")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "ادخل رقم الهويه")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "رقم الهويه 14 رقم")]
        [DataType(DataType.Text, ErrorMessage = "ادخل رقم الهويه بشكل صحيح")]
        public string CardId { get; set; }

        [Required(ErrorMessage = "اختر طريقة الدفع")]
        [DataType(DataType.Text, ErrorMessage = "ادخل الاسم بشكل صحيح")]
        public string PaymentType { get; set; }

        [Required(ErrorMessage = "ادخل العنوان بالكامل")]
        [StringLength(150, MinimumLength = 20, ErrorMessage = "ادخل العنوان بالتفصيل")]
        public string Address { get; set; }
        public byte[] photo1 { get; set; }
        public byte[] photo2 { get; set; }
        public string Notes { get; set; }
        public bool IsPaid { get; set; }
        public string Date { get; set; }
        public string OrderType { get; set; }
        public Boolean Confirmed { get; set; }

        [Required(ErrorMessage = "ادخل تاريخ الميلاد")]
        [DataType(DataType.Date, ErrorMessage = "ادخل تاريخ الميلاد بشكل صحيح")]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = "ادخل النوع")]
        public string Kind { get; set; }

        [Required(ErrorMessage = "ادخل الديانه")]
        public string Religion { get; set; }

    }
}
