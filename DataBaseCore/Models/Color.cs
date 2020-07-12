﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseCore.Models
{
    public class Color
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
