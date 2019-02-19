using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using log2log.Services;

namespace log2log
{
    internal interface ILoglog
    {
        /// <summary>
        /// Create a concrete type of logger
        /// </summary>
        /// <returns></returns>
        ILoggingExecute CreateLogger();

    }
}
