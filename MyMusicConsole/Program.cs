using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicPersistence;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new MyMusicContext())
            {
                context.EmployeeAccounts.Add(new EmployeeAccount(1, "username1", "parola1"));
                context.SaveChanges();
            }
        }
    }
}
