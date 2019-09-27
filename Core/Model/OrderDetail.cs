using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class OrderDetail
    {
        public OrderDetail()
        {
        }

        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int TaxRate { get; set; }

        public int? DiscountRate { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal GrossTotal { get; set; }

        public decimal TotalAmount { get; set; }

        public IList<OrderDetailFeature> OrderDetailFeatures { get; set; }

    }
}
