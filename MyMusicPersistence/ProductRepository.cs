using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicPersistence
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MyMusicContext context) : base(context) { }

        public IEnumerable<Product> SearchProducts(string searchTerm)
        {
            return MyMusicContext.Products.FromSqlRaw("exec dbo.SearchProductByName '"+searchTerm+"'").ToList();
        }
        public IEnumerable<Product> OrderProductsByName()
        {
            return MyMusicContext.Products.FromSqlRaw("exec dbo.OrderProductsByName").ToList();
        }
        public IEnumerable<Product> OrderProductsByPriceAsc()
        {
            return MyMusicContext.Products.FromSqlRaw("exec dbo.OrderProductsByPriceAsc").ToList();
        }
        public IEnumerable<Product> OrderProductsByPriceDesc()
        {
            return MyMusicContext.Products.FromSqlRaw("exec dbo.OrderProductsByPriceDesc").ToList();
        }
        public MyMusicContext MyMusicContext
        {
            get { return context as MyMusicContext; }
        }
    }
}
