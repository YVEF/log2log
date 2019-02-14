using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Services
{
    public interface ILogWriter
    {
        /// <summary>
        /// Write to file or xml or database
        /// </summary>
        bool Write();
    }
}
