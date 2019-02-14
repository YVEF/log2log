using log2log.Core;
using System.Collections.Generic;



namespace log2log.Services
{
    internal interface ILoggingExecute
    {
        void AddDataToLog(ILogData data);
    }
}
