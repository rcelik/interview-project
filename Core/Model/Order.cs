using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Order
    {
        public Order()
        {
        }

        public int Id { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal TotalAmount { get; set; }

        public IList<OrderDetail> OrderDetails { get; set; }
    }
}
