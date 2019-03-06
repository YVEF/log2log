using log2log.Services;
using log2log.Services.DbConfig;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Configuration
{
    internal static class LogConfig
    {
        
        public static ILogWriter[] GetLogWriter(string connectionPathFile, ConnectionStringSettings connectionPathDb)
        {
            ILogWriter[] logWriters = new ILogWriter[2];
            logWriters[0] = new TextLogWriter(connectionPathFile);
            if (connectionPathDb != null)
                logWriters[1] = new DbLogWriter(new DbFactory(connectionPathDb).CreateContext());
            return logWriters;
        }
    }
}
