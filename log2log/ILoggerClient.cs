using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log
{
    /// <summary>
    /// This is main logger instance for client
    /// </summary>
    public interface ILoggerClient
    {
        /// <summary>
        /// Set a message for info level
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        bool Info(string message);
        /// <summary>
        /// Set a message for warning level
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        bool Warning(string message);
        /// <summary>
        /// Set a message for error level
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        bool Error(string message);
    }
}
