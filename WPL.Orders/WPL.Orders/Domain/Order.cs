using System;

namespace WPL.Orders.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public string Description { get; set; }
    }
}