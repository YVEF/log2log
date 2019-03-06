using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Configuration
{
    internal static class LogConfigHelper
    {
        private static System.Configuration.Configuration configManager;

        public static System.Configuration.Configuration GetConfigFromDomain()
        {
            if(configManager == null)
            {
                var fileInfo = new DirectoryInfo(Path.GetFullPath
                    (AppDomain.CurrentDomain.BaseDirectory + @"\..\..\")).GetFiles("*.config")[0];
                var configMap = new ExeConfigurationFileMap();
                configMap.ExeConfigFilename = fileInfo.FullName;
                configManager = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            }
            return configManager;
        }
    }
}
