using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log
{
    public interface ILoggerClient
    {
        bool Info(string message);
        bool Warning(string message);
        bool Error(string message);
    }
}
