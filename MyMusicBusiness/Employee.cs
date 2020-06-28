using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBusiness
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public DateTime EmployementDate { get; set; }

        public Employee(string name,string phoneNumber,string adress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Adress = adress;
            EmployementDate = DateTime.Now;
        }
        public Employee() { }
    }
}
