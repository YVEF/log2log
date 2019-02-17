﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Configuration
{
    public static class LogConfigHelper
    {
        public static System.Configuration.Configuration GetConfigFromDomain()
        {
            var fileInfo = new DirectoryInfo(Path.GetFullPath
                (AppDomain.CurrentDomain.BaseDirectory + @"\..\..\")).GetFiles("*.config")[0];
            var configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = fileInfo.FullName;
            return ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None); ;
        }
    }
}