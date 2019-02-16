using log2log.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace log2log.Services
{
    public class LoggingExecute : ILoggingExecute
    {
        private Queue<ILogData> loggerQueue;
        public delegate bool LogWriterEventHandler();
        public event LogWriterEventHandler WriteHandler;
        private Timer timer;

        public LoggingExecute(params ILogWriter[] logWriters)
        {
            loggerQueue = new Queue<ILogData>();
            foreach(var item in logWriters)
            {
                WriteHandler += item.Write;
                item.loggerQueue = loggerQueue;
            }
            timer = new Timer(2000);
            timer.Elapsed += ActiveTimerElapsed;
            
        }

        public void AddDataToLog(ILogData data)
        {
            timer.Stop();
            loggerQueue.Enqueue(data);
            timer.Start();
        }

        public ILoggerClient GetLoggerClient() => new LoggerClient(this);

        void ActiveTimerElapsed(object obj, ElapsedEventArgs e) => WriteHandler();
    }
}
