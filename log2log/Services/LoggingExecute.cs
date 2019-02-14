using log2log.Core;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace log2log.Services
{
    class LoggingExecute : ILoggingExecute
    {
        private static object lockObj = new object();
        private Queue<ILogData> loggerQueue = new Queue<ILogData>();
        private ILogWriter logWriter;

        public LoggingExecute(ILogWriter logWriter)
        {
            this.logWriter = logWriter;
        }

        public void AddDataToLog(ILogData data)
        {
            loggerQueue.Enqueue(data);

            if (loggerQueue.Count > 100)
            {
                logWriter.Write();
            }
            
        }
    }
}
