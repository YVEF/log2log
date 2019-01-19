using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace log2log.Configuration
{
    public class LogConfigurationHandler
    {
        public void Init()
        {
            LogConfigSection logConfig = (LogConfigSection)ConfigurationManager.GetSection("log2log");
            Debug.Write(logConfig.SettingsItems[0].Name);
            Debug.Write(logConfig.SettingsItems[0].Path);

        }
        

    }
}
