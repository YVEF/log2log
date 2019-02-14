using log2log.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Configuration
{
    public static class LogConfig
    {
        public static ILogWriter GetLogWriter(string connectionPath)
        {
            return new TextLogWriter(connectionPath);
        }
    }
}
