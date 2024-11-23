using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    public class Product
    {
        public ProductId Id { get; set; }
        public string Name { get; set; }
        public Money Price { get; set; }
        public string Description { get; set; }
    }

    public record Money(string Currency,decimal Cost);
}
