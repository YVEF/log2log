using log2log.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace log2log.Services
{
    public class LoggingExecute : ILoggingExecute
    {
        private Queue<ILogData> loggerQueue; 
        public ILogWriter logWriter;

        public delegate void LogWriterEventHandler();
        public event LogWriterEventHandler WriteHandler;

        public LoggingExecute(ILogWriter logWriter)
        {
            loggerQueue = new Queue<ILogData>();
            this.logWriter = logWriter;
            logWriter.loggerQueue = loggerQueue;
            WriteHandler += logWriter.Write;
        }

        public void AddDataToLog(ILogData data)
        {
            loggerQueue.Enqueue(data);

            if (loggerQueue.Count > 100) WriteHandler();
        }

        public ILoggerClient GetLoggerClient()
        {
            return new LoggerClient(this);
        }
    }
}
