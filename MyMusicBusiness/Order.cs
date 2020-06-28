using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MyMusicBusiness
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public Order(int customerId, int productId, int employeeId,int quantity,DateTime date)
        {
            CustomerId = customerId;
            ProductId = productId;
            EmployeeId = employeeId;
            Quantity = quantity;
            Date = date;
        }
        public Order(){}
    }
}
