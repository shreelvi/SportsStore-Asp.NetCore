using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    // a class that implements the IProductRepository interface and gets its data using EF core.
    public class EFProductRepository: IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Product> Products => context.Products;

        //TODO: Additional functionality later
    }
}
