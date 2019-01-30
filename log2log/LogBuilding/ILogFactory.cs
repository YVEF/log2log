using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.LogBuilding
{
    public interface ILogFactory
    {
        /// <summary>
        /// This name declare in .config
        /// </summary>
        string FileName { get; }
        /// <summary>
        /// This path declare in .config
        /// </summary>
        string Path { get; }
        /// <summary>
        /// Level of log status
        /// </summary>
        string Level { get; }
        /// <summary>
        /// Create new logger instance
        /// </summary>
        /// <returns>New logger</returns>
        ILoglog CreateLoger();
        
    }
}
