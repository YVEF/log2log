using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace log2log
{
    public interface ILoglog : IDisposable
    {
        /// <summary>
        /// Info level for standard logging
        /// </summary>
        /// <param name="message"></param>
        void Info(string message);
        /// <summary>
        /// Error level for loggin exception message
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
        /// <summary>
        /// Warning level
        /// </summary>
        /// <param name="message"></param>
        void Warning(string message);
        /// <summary>
        /// Fatal level message for exception before close your app
        /// </summary>
        /// <param name="message"></param>
        void Fatal(string message);

    }
}
