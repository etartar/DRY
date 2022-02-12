using System;

namespace DRY.DesignPatterns.PrototypePattern.Scenario1.Concrete
{
    public class Order : ICloneable
    {
        private Order()
        {
        }

        public Guid Id { get; private set; }
        public string Contact { get; private set; }
        public string Address { get; private set; }
        public decimal TotalPrice { get; private set; }
        
        public static Order Create(string contact, string address, decimal totalPrice)
        {
            return new Order
            {
                Id = Guid.NewGuid(),
                Contact = contact,
                Address = address,
                TotalPrice = totalPrice
            };
        }

        public Order Repeat()
        {
            Order repeatOrder = (Order)Clone();
            repeatOrder.Id = Guid.NewGuid();
            return repeatOrder;
        }

        public object Clone()
        {
            Order tempOrder = (Order)this.MemberwiseClone();
            return tempOrder;
        }
    }
}
