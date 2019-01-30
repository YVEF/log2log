using log2log.Core;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;



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

        public void AddLog(ILogData data)
        {
            loggerQueue.Enqueue(data);

            if (loggerQueue.Count > 100) WriteToLog();
        }

        private void WriteToLog()
        {
            lock (lockObj)
            {
                
            } 
        }
    }
}
