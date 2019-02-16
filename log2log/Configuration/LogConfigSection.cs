using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Configuration
{
    public class LogConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("folders")]
        public LogConfigurationCollection LogItems => (LogConfigurationCollection)base["folders"];
    }
}
