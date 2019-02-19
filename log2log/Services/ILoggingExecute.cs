using log2log.Core;
using System.Collections.Generic;



namespace log2log.Services
{
    /// <summary>
    /// Main executer of logger
    /// </summary>
    public interface ILoggingExecute
    {
        /// <summary>
        /// You can add any data that ILogData implement
        /// </summary>
        /// <param name="data"></param>
        void AddDataToLog(ILogData data);
        /// <summary>
        /// Return a logger instance for client
        /// </summary>
        /// <returns></returns>
        ILoggerClient GetLoggerClient();
    }
}
