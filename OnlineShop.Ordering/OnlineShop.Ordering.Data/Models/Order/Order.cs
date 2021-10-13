using OnlineShop.Ordering.Data.Models.Buyer;
using System;
using System.Collections.Generic;

namespace OnlineShop.Ordering.Data.Models.Order
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Address Address { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public List<Guid> ItemsGuids { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}
