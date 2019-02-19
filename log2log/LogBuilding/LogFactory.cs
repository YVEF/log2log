using log2log.Configuration;
using log2log.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.LogBuilding
{
    internal class LogFactory : ILogFactory
    {
        public ILoglog loglog { get; set; }

        public LogFactory(ILoglog loglog)
        {
            this.loglog = loglog;
        }

        public ILoggingExecute CreateLogWriter()
        {
            return loglog.CreateLogger();
        }

        private LogElement GetConfiguration() => LogConfigurationHandler.GetLogConfig(0);

    }
}
