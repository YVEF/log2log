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

        public string FileName { get; set; } /* => GetConfiguration().Name;*/

        public string Path { get; set; } /* => GetConfiguration().Path;*/

        public string Level { get; set; } /* => GetConfiguration().Level;*/
        public LogFactory(string fileName, string path, string level)
        {
            FileName = fileName;
            Path = path;
            Level = level;
        }

        public ILoglog CreateLoger()
        {
            return new Loglog(FileName, Path);
        }

        private LogElement GetConfiguration() => LogConfigurationHandler.GetLogConfig(0);

    }
}
