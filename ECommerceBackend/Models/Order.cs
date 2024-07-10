using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ECommerceBackend.Models
{
public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [ValidateNever]
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
