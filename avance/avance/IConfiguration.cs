using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;
using avance;

namespace avance
{
   public interface IConfiguration
    {
         string directorio { get; }

        ISQLitePlatform plataforma { get; }


    }
}
