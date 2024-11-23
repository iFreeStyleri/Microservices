using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public class PoolProduct
    {
        public PoolProductId Id { get; set; }
        public CategoryId CategoryId { get; set; }
        public ProductId ProductId { get; set; }
    }

    public record PoolProductId(long Id);
}
