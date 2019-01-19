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
        private readonly string nameOfLogger;
        private ILogData logData = new LogData();
        private ILoggingExecute loggingExecute;

        internal Loglog(string name, string level, string path)
        {
            nameOfLogger = name;
            logData.Level = level;
            loggingExecute = new LoggingExecute(path);
        }

        public void Info(string message)
        {
            logData.Message = message;
            loggingExecute.AddLog(logData);
        }

        

        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Fatal(string message)
        {
            Console.WriteLine(message);
        }

        

        public void Warning(string message)
        {
            Console.WriteLine(message);
        }



        #region IDisposable Support

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        ~Loglog()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
