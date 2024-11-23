using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Products;

namespace Domain.Orders
{
    public class PoolItem
    {
        public PoolItemId Id { get; private set; }
        public ProductId ProductId { get; private set; }
        public OrderId OrderId { get; set; }

        public PoolItem(PoolItemId poolItemId, ProductId productId, OrderId orderId)
        {
            Id = poolItemId;
            ProductId = productId;
            OrderId = orderId;
        }
    }
}
