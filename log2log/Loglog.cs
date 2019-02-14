using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using log2log.Services;
using log2log.Core;
using log2log.Configuration;

namespace log2log
{
    public class Loglog : ILoglog
    {
        private string path;

        public Loglog(string path)
        {
            this.path = path;
        }

        public ILoggingExecute CreateLogger()
        {
            return new LoggingExecute(LogConfig.GetLogWriter(path));
        }

        public void Dispose()
        {
            //logData = null;
            //loggingExecute = null;
        }

        
    }
}
