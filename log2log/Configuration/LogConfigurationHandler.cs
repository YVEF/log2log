using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace log2log.Configuration
{
    public static class LogConfigurationHandler
    {
        public static LogElement GetLogConfig(int index)
        {
            LogConfigSection logConfig = (LogConfigSection)ConfigurationManager.GetSection("log2log");

            return logConfig.SettingsItems[index];
        }
        

    }
}
