using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products;
using Domain.Profiles;

namespace Domain.Orders
{
    public class Order
    {
        private readonly HashSet<PoolItem> _poolItems = new();
        public OrderId Id { get; set; }
        public CustomerId CustomerId { get; set; }
        public Address Address { get; set; }

        private Order(){}


        public void Add(ProductId productId)
        {
            _poolItems.Add(new PoolItem(new PoolItemId(0), productId, Id));
        }
        public static Order Create(CustomerId customerId, Address address)
        {
            var order = new Order
            {
                Id = new OrderId(0),
                CustomerId = customerId,
                Address = address
            };
            return order;
        }
    }
}
