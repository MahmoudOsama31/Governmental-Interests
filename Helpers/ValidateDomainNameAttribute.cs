using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Helpers
{
    // دا بتاع الاميل بس انا سايبها شويه عشان عايز اتعلم الفاليداشن اتريبيوت
    /*
    public class ValidateDomainNameAttribute : ValidationAttribute
    {
        private readonly string _allowDomainName;

        public ValidateDomainNameAttribute(string AllowDomainName)
        {
            _allowDomainName = AllowDomainName;
        }
        public override bool IsValid(object value)
        {
            string[] vals = value.ToString().Split("@");
            return vals[1].ToUpper() == _allowDomainName.ToUpper();
        }
    }*/
}
