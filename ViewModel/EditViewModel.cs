using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.ViewModel
{
    public class EditViewModel
    {
        public string Id { get; set; }

        [Display(Name ="رقم الهويه")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "برجاء ادخال الاسم الاول")]
        [Display(Name = "الاسم الاول")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "برجاء ادخال الاسم الاخير")]
        [Display(Name = "الاسم الاخير")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "برجاء ادخال رقم الهاتف")]
        [Phone]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "رقم الهاتف 11 رقم")]
        [Display(Name = "رقم الهاتف")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "برجاء ادخال البريدالالكتروني")]
        [Display(Name = "البريدالالكتروني")]
        [EmailAddress]
        [RegularExpression(@"[a-z0-9._%+-]+@gmail.com", ErrorMessage = "ex:a@gmail.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ادخل كلمة المرور القديمه")]
        [Display(Name = " كلمة المرور الحالي")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "ادخل كلمة المرور")]
        [Display(Name = "كلمة المرور الجديده")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "ادخل كلمة المرور")]
        [Display(Name = "كلمة المرور الجديده مره اخري")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "كلمة المرور ليست متطابقه  ")]
        public string ConfirmPassword { get; set; }
    }
}
