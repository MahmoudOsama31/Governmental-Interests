﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GI.ViewModel
{
    public class RoleViewModel
    {
        [Required,StringLength(256)]
        public string Name { get; set; }
    }
}
