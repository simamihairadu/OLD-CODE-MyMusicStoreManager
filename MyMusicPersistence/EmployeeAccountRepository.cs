using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicPersistence
{
    public class EmployeeAccountRepository : Repository<EmployeeAccount>, IEmployeeAccountRepository
    {
        public EmployeeAccountRepository(MyMusicContext context) : base(context) {}

        public EmployeeAccount GetEmployeeByUsername(string username)
        {
            return MyMusicContext.EmployeeAccounts.Single(e => e.Username == username);
        }

        public MyMusicContext MyMusicContext
        {
            get { return context as MyMusicContext; }
        }
    }
}
