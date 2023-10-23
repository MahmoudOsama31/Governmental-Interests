using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "ادخل رقم الهويه")]
        [Display(Name = "رقم الهويه")]
        [StringLength(14,MinimumLength =14,ErrorMessage = "رقم الهويه 14 رقم")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "ادخل كلمة المرور")]
        [Display(Name = "كلمة المرور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
