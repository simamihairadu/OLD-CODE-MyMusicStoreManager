using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicPersistence
{
    public class OrderRepository : Repository<Order>,IOrderRepository
    {
        public OrderRepository(MyMusicContext context) : base(context) {}
        public MyMusicContext MyMusicContext
        {
            get { return context as MyMusicContext; }
        }
    }
}
