using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using log2log.Services;
using log2log.Core;
using log2log.Configuration;
using System.Configuration;

namespace log2log
{
    internal class Loglog : ILoglog
    {
        private string path;
        private ConnectionStringSettings conStrSettings;

        public Loglog(string path) : this(path, null) { }


        public Loglog(string path, ConnectionStringSettings conStrSettings)
        {
            this.path = path;
            this.conStrSettings = conStrSettings;
        }

        public ILoggingExecute CreateLogger()
        {
            return new LoggingExecute(LogConfig.GetLogWriter(path));
        }        
    }
}
