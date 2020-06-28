using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBusiness
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }

        public Customer(string name,string phoneNumber,string email,string city,string adress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            City = city;
            Adress = adress;
        }
        public Customer(){}
    }
}
