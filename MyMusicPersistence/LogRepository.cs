using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMusicBusiness;
using Microsoft.EntityFrameworkCore;

namespace MyMusicPersistence
{
    public class LogRepository : Repository<Log>, ILogRepository
    {
        public LogRepository(MyMusicContext context) : base(context) {}
        public MyMusicContext MyMusicContext
        {
            get { return context as MyMusicContext; }
        }
    }
}
