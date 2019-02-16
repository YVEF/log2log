using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//#pragma 

namespace log2log.Configuration
{
    [ConfigurationCollection(typeof(LogElement), AddItemName ="setting")]
    public class LogConfigurationCollection : ConfigurationElementCollection
    {
        public LogConfigurationCollection()
        {
            Console.WriteLine("Start a LogConfigurationCollection .ctor");
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new LogElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((LogElement)element).Name;
        }

        public LogElement this[int index] => (LogElement)BaseGet(index);
    }
}
