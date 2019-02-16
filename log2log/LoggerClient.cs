using log2log.Core;
using log2log.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log
{
    public class LoggerClient : ILoggerClient
    {
        private ILoggingExecute loggingProcess;

        public LoggerClient(ILoggingExecute loggingProcess)
        {
            this.loggingProcess = loggingProcess;
        }

        public bool Info(string message)
        {
            try
            {
                loggingProcess.AddDataToLog(new LogData("Info", message));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Warning(string message)
        {
            try
            {
                loggingProcess.AddDataToLog(new LogData("Warning", message));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Error(string message)
        {
            try
            {
                loggingProcess.AddDataToLog(new LogData("Error", message));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
