using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    //Implements the IPrductRepository interface by returning a fixed collection of Product objects
    //as the value of the products property
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Name = "Football", Price = 25 },
            new Product {Name = "Surf board", Price = 179 },
            new Product {Name = "Running shoes", Price = 95 },

        };
    }
}
