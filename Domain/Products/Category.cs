using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public class Category
    {
        private readonly HashSet<PoolProduct> _poolProducts = new();

        public CategoryId Id {get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public void Add(ProductId productId)
        {
            var product = new PoolProduct
            {
                ProductId = productId,
                CategoryId = Id
            };
            _poolProducts.Add(product);
        }
    }
}
