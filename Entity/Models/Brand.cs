﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Avatar { get; set; }
        public bool? IsActive { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual ICollection<Product> Products { get; set; }
    }
}
