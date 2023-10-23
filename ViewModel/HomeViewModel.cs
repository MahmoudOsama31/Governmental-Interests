using GI.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.ViewModel
{
    public class HomeViewModel
    {
        public int ContactUsID { get; set; }

        [Required(ErrorMessage = "ادخل الاسم")]
        [Display(Name = "الاسم بالكامل")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "ادخل البريد الالكتروني")]
        [Display(Name = "البريد الالكتروني")]
        [DataType(DataType.EmailAddress, ErrorMessage = "ادخل البريد بشكل صحيح")]
        [RegularExpression(@"[a-z0-9._%+-]+@gmail.com", ErrorMessage = "ex:a@gmail.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ادخل الهاتف")]
        [Display(Name = "الهاتف")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "رقم الهاتف 11 رقم")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "ادخل الهاتف بشكل صحيح")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "ادخل الرساله")]
        [Display(Name = "الرساله")]
        public string Message { get; set; }

        [Required(ErrorMessage = "ادخل خدمتك")]
        public string Serves { get; set; }
        public string Search { get; set; }
    }
}

