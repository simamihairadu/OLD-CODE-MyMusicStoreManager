using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBusiness
{
    public class EmployeeAccount
    {
        public int EmployeeAccountId { get; set; }
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public EmployeeAccount(int employeeId,string username,string password)
        {
            EmployeeId = employeeId;
            Username = username;
            Password = password;
        }
        public EmployeeAccount(){}
    }
}
