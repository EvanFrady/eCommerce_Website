﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce_Website.Models
{
    public class SpecialTag
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
