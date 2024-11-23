using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Profiles
{
    public class Customer
    {
        private readonly HashSet<PoolOrder> _poolOrders = new();
        public CustomerId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        private Customer(){}
        public void Add(OrderId orderId)
        {
            var order = new PoolOrder
            {
                CustomerId = Id,
                OrderId = orderId
            };
            _poolOrders.Add(order);
        }

        public static Customer Create(string name, string email, string phone, string password)
        {
            var customer = new Customer
            {
                Email = email,
                Name = name,
                Phone = phone,
                Password = password
            };
            return customer;
        }
    }
}
