using log2log.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.LogBuilding
{
    public interface ILogFactory
    {
        ILoglog loglog { get; set; }
        ILoggingExecute CreateLogWriter();
        
    }
}
