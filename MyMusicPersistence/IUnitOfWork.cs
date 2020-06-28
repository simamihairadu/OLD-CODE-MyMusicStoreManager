using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicBusiness;

namespace MyMusicPersistence
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeAccountRepository EmployeeAccounts { get; }
        IProductRepository Products { get; }
        ICustomerRepository Customers { get; }
        IEmployeeRepository Employees { get;  }
        IOrderRepository Orders { get;  }
        ILogRepository Logs { get;  }
        int Complete();
    }
}
