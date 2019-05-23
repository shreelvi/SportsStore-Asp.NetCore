using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    /// <summary>
    /// Interface that maps the product objects to the database
    /// A class that depends on the IProductRepository interface
    /// can obtain Product objects without needing to know anything about data
    /// Reference: Book (link in the readme file)
    /// </summary>
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
