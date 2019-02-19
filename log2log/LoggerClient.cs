using log2log.Core;
using log2log.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log
{
    /// <summary>
    /// Logger client is implementation of ILoggerClient and use different level for information and filtration.
    /// Main type is ILoggerClient but you can use this implementation of interface.
    /// </summary>
    public class LoggerClient : ILoggerClient
    {
        private ILoggingExecute loggingProcess;

        internal LoggerClient(ILoggingExecute loggingProcess)
        {
            this.loggingProcess = loggingProcess;
        }

        /// <summary>
        /// Message of indo level
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Message of warning level
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Message of error level
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
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
