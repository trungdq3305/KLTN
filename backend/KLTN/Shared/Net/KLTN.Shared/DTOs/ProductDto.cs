﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.Shared.DTOs
{
    public class ProductDto
    {
        public string? Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }
    }
}
