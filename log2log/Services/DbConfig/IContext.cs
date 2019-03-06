using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Services.DbConfig
{
    interface IContext : IDisposable
    {
        IDbCommand CreateCommand();
    }
}
