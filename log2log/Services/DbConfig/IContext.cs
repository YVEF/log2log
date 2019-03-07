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
        /// <summary>
        /// The method create a command for add ILogData in db
        /// </summary>
        /// <returns></returns>
        IDbCommand CreateCommand();
    }
}
