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
        string Name { get; }
        /// <summary>
        /// This path declare in .config
        /// </summary>
        string Path { get; }
        /// <summary>
        /// This level declare in .config
        /// </summary>
        string Level { get; }
        /// <summary>
        /// Create new logger instance
        /// </summary>
        /// <returns>New logger</returns>
        ILoglog CreateLoger();
    }
}
