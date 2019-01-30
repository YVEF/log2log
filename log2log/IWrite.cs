using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log
{
    public interface IWrite : IDisposable
    {
        void ExecuteWrite();
        void Reset();
    }
}
