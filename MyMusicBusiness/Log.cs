using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBusiness
{
    public class Log
    {
        public int LogId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTime { get; set; }

        public Log(Product product)
        {
            ProductId = product.ProductId;
            Quantity = product.Count;
            DateTime = DateTime.Now;
        }
        public Log() { }
    }
}
