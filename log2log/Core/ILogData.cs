using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Core
{
    /// <summary>
    /// It's interface for log data
    /// </summary>
    public interface ILogData : IDisposable
    {
        /// <summary>
        /// Time of message
        /// </summary>
        string LogTime { get; set; }
        /// <summary>
        /// This is level mark of logger for filter
        /// </summary>
        string Level { get; set; }
        /// <summary>
        /// Current message from logger client
        /// </summary>
        string Message { get; set; }
    }
}
