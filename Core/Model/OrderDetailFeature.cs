using System;
namespace Core.Model
{
    public class OrderDetailFeature
    {
        public OrderDetailFeature()
        {
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal AdditionalPrice { get; set; }
    }
}
