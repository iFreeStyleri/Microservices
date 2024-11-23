using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Orders;

namespace Domain.Profiles
{
    public class PoolOrder
    {
        public PoolOrderId Id { get; set; }
        public CustomerId CustomerId { get; set; }
        public OrderId OrderId { get; set; }
    }

    public record PoolOrderId(long Id);
}
