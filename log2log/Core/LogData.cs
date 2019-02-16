using log2log.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Core
{
    public struct LogData : ILogData
    {
        public LogData(string level, string message)
        {
            Level = level;
            Message = message;
            this.LogTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fffffff");
        }

        public string LogTime { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }

        public void Dispose()
        {
            Level = null;
            Message = null;
        }
    }
}
