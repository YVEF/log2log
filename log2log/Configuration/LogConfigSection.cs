using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Configuration
{
    internal class LogConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("settings")]
        public LogConfigurationCollection LogItems => (LogConfigurationCollection)base["settings"];
    }
}
