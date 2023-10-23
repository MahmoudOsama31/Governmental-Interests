using Identity.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "ادخل البريد الالكتروني")]
        [Display(Name = "البريد الالكتروني")]
        [DataType(DataType.EmailAddress, ErrorMessage = "ادخل البريد بشكل صحيح")]
        [RegularExpression(@"[a-z0-9._%+-]+@gmail.com", ErrorMessage = "ex:a@gmail.com")]
        public string Email { get; set; }

        [Required(ErrorMessage ="ادخل الاسم الاول")]
        [Display(Name ="الاسم الاول")]
        [DataType(DataType.Text)]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "ادخل الاسم الاخير")]
        [Display(Name = "الاسم الاخير")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "ادخل الهاتف")]
        [Display(Name = "الهاتف")]
        [StringLength(11,MinimumLength =11, ErrorMessage = "رقم الهاتف 11 رقم")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "ادخل الهاتف بشكل صحيح")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "ادخل رقم الهويه")]
        [Display(Name = "رقم الهويه")]
        [StringLength(14,MinimumLength =14, ErrorMessage = "رقم الهويه 14 رقم")]
        [DataType(DataType.Text, ErrorMessage = "ادخل رقم الهويه بشكل صحيح")]
        public string Card { get; set; }

        [Required(ErrorMessage = "ادخل كلمة المرور")]
        [Display(Name = "كلمة المرور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "ادخل كلمة المرور")]
        [Display(Name = "كلمة المرور")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "كلمة المرور ليست متطابقه  ")]
        public string ConfirmPassword { get; set; }
    }
}
