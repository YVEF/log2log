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

        public string Name => GetConfiguration().Name;

        public string Path => GetConfiguration().Path;

        public string Level => GetConfiguration().Level;

        public ILoglog CreateLoger()
        {
            return new Loglog(Name, Path, Level);
        }

        private LogElement GetConfiguration() => LogConfigurationHandler.GetLogConfig(0);

    }
}
