using log2log.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.LogBuilding
{
    public class LogFactory : ILogFactory
    {

        public string Message { get; set; } /* => GetConfiguration().Name;*/

        public string Path { get; set; } /* => GetConfiguration().Path;*/

        public string Level { get; set; } /* => GetConfiguration().Level;*/

        public LogFactory(string message, string path, string level)
        {
            Message = message;
            Path = path;
            Level = level;
        }

        public ILoglog CreateLoger()
        {
            return new Loglog(Message, Level, Path);
        }

        private LogElement GetConfiguration() => LogConfigurationHandler.GetLogConfig(0);

    }
}
