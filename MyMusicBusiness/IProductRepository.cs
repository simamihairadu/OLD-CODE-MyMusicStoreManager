using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBusiness
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> SearchProducts(string searchTerm);
        IEnumerable<Product> OrderProductsByName();
        IEnumerable<Product> OrderProductsByPriceAsc();
        IEnumerable<Product> OrderProductsByPriceDesc();
    }
}
