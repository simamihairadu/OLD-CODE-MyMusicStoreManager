using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBusiness
{
    public interface IEmployeeAccountRepository : IRepository<EmployeeAccount>
    {
        EmployeeAccount GetEmployeeByUsername(string username);
    }
}
