﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.Size
{
    public class SizeDto
    {
        public int Id { get; set; }
        public string SizeName { get; set; }
        public int? Price { get; set; }
        public int? ProductId { get; set; }
        public bool? IsActive { get; set; }
    }
}
