using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMusicBusiness;

namespace MyMusicPersistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyMusicContext context;

        public IProductRepository Products { get; private set; }
        public IEmployeeAccountRepository EmployeeAccounts { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public ILogRepository Logs { get; private set; }
        public UnitOfWork(MyMusicContext context)
        {
            this.context = context;
            EmployeeAccounts = new EmployeeAccountRepository(this.context);
            Products = new ProductRepository(this.context);
            Customers = new CustomerRepository(this.context);
            Employees = new EmployeeRepository(this.context);
            Orders = new OrderRepository(this.context);
            Logs = new LogRepository(this.context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
