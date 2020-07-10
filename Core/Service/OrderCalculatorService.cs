using System;
namespace Core.Service
{
    public class OrderCalculatorService
    {
        public OrderCalculatorService()
        {
        }
        public void CalculateOrderTotal(ref Order Order)
         {
             if (Order.OrderDetails != null)
             {
                 decimal UnitPriceWithOutTaxes = 0;
                 foreach (OrderDetail OrderDetail in Order.OrderDetails)
                 {
                     UnitPriceWithOutTaxes = Math.Round(OrderDetail.UnitPrice / (1 + ((decimal)OrderDetail.TaxRate / 100)),2);

                     OrderDetail.TaxAmount = (OrderDetail.UnitPrice - UnitPriceWithOutTaxes) ;
                     OrderDetail.DiscountAmount = (OrderDetail.UnitPrice * ((decimal)OrderDetail.DiscountRate /100)) * OrderDetail.Quantity;
                     OrderDetail.GrossTotal = ((UnitPriceWithOutTaxes * OrderDetail.Quantity)  - (UnitPriceWithOutTaxes * ((decimal)OrderDetail.DiscountRate / 100)) * OrderDetail.Quantity) ;
                     OrderDetail.TotalAmount = (OrderDetail.UnitPrice * OrderDetail.Quantity);

                     Order.GrossAmount += OrderDetail.GrossTotal;
                     Order.TaxAmount += (OrderDetail.TaxAmount * OrderDetail.Quantity);
                     Order.TotalDiscount += OrderDetail.DiscountAmount;
                     Order.TotalAmount += (OrderDetail.UnitPrice * OrderDetail.Quantity) - OrderDetail.DiscountAmount;
                 }
             }
         }

    }
}
