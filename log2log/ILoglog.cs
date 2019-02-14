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
        /// Connect to log writer
        /// </summary>
        void Execute();

    }
}
