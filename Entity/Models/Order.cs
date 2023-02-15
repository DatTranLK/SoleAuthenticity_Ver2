﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entity.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int? TotalPrice { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? ShippingAddress { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentMethod { get; set; }
        public int? CustomerId { get; set; }
        public int? StaffId { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual Account? Customer { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual Account? Staff { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
