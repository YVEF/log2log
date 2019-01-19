using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;



namespace log2log.Services
{
    class LoggingExecute : ILoggingExecute
    {
        private string path;
        private static object lockObj = new object();
        private Queue<ILogData> loggerQueue = new Queue<ILogData>();

        public LoggingExecute(string path)
        {
            this.path = path;
        }

        public void AddLog(ILogData data)
        {
            loggerQueue.Enqueue(data);

            if (loggerQueue.Count > 100) WriteToLogFile();
        }

        private void WriteToLogFile()
        {
            lock (lockObj)
            {
                using (StreamWriter stream = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    foreach(var item in loggerQueue)
                    {
                        stream.Write(item.dateTime);
                        stream.Write(item.Level);
                        stream.Write(item.Message);
                    }
                    loggerQueue.Clear();
                }
            } 
        }
    }
}
