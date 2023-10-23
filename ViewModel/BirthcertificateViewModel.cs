using GI.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.ViewModel
{
    public class BirthcertificateViewModel
    {
        public Birthcertificate birthcertificate { get; set; }

        [Required(ErrorMessage = "ادخل الصوره الثانيه")]
        public IFormFile photo1 { get; set; }

        [Required(ErrorMessage = "ادخل الصوره الاول")]
        public IFormFile photo2 { get; set; }

        public string Search { get; set; }

    }
}
