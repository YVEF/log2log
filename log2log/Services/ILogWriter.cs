using log2log.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Services
{
    /// <summary>
    /// This is an interface that any writers can implement
    /// </summary>
    public interface ILogWriter : IDisposable
    {
        /// <summary>
        /// Write to file or xml or database
        /// </summary>
        bool Write();
        /// <summary>
        /// Link on data queue
        /// </summary>
        Queue<ILogData> loggerQueue { get; set; }
    }
}
