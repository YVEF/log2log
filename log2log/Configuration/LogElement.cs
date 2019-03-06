using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Configuration
{
    internal class LogElement : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Name
        {
            get => (string)base["name"]; 
            set => base["name"] = value;
        }
        
        [ConfigurationProperty("path", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string Path
        {
            get => (string)base["path"]; 
            set => base["path"] = value; 
        }

        [ConfigurationProperty("levelFilter", DefaultValue = false, IsKey = false, IsRequired = false)]
        public bool levelFilter
        {
            get => (bool)base["levelFilter"];
            set => base["level"] = value;
        }

        [ConfigurationProperty("toDataBase", DefaultValue = false, IsKey = false, IsRequired = false)]
        public bool toDataBase
        {
            get => (bool)base["toDataBase"];
            set => base["toDataBase"] = value;
        }

        [ConfigurationProperty("dbConnectionName", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string dbConnectionName
        {
            get => base["dbConnectionName"] as string;
            set => base["dbConnectionName"] = value;
        }
    }
}
