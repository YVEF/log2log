using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using log2log.Services;
using log2log.Core;

namespace log2log
{
    internal class Loglog : ILoglog
    {
        private string message;
        private ILogData logData = new LogData();
        private ILoggingExecute loggingExecute;
        private ILogWriter logWriter;
        private string path;

        public Loglog(string message, string level, string path)
        {
            logData.Message = message;
            logData.Level = level;
            this.path = path;
            loggingExecute = new LoggingExecute(logWriter);
        }

        public void Execute()
        {
            loggingExecute.AddDataToLog(logData);
        }

        public void Dispose()
        {
            logData = null;
            loggingExecute = null;
        }

        
    }
}
