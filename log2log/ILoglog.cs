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
        void Info(string message);
        void Error(string message);
        void Warning(string message);
        void Fatal(string message);

    }
}
