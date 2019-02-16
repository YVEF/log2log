using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Core
{
    public interface ILogData : IDisposable
    {
        string LogTime { get; set; }
        string Level { get; set; }
        string Message { get; set; }
    }
}
