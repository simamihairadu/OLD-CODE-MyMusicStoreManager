using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusicBusiness
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Product(string name,string brand,double price,int count)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Count = count;
        }

        public Product() { }
    }
}
