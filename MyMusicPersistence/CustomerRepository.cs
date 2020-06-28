using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicPersistence
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MyMusicContext context) : base(context) {}

        public MyMusicContext MyMusicContext
        {
            get { return context as MyMusicContext; }
        }
    }
}
