using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.Models
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }

        [Required]
        [StringLength(16,MinimumLength =16,ErrorMessage ="ادخل الرقم بشكل صحيح")]
        public string CardNumber { get; set; }
        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "ادخل الرقم بشكل صحيح")]
        [RegularExpression(@"/ ^(0[1 - 9] | 1[0 - 2])\/? ([0 - 9]{4}|[0-9]{2})$/;",ErrorMessage ="ادخل الرقم بشكل صحيح")]
        public string EXPIRATIONDATE { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "ادخل الرقم بشكل صحيح")]
        public string CVCode { get; set; }
        [Required]
        public string CardOwner { get; set; }
    }
}
