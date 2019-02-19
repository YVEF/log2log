using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace log2log.Configuration
{
    [ConfigurationCollection(typeof(LogElement), AddItemName ="setting")]
    internal class LogConfigurationCollection : ConfigurationElementCollection
    {

        protected override ConfigurationElement CreateNewElement() => new LogElement();

        protected override object GetElementKey(ConfigurationElement element) => ((LogElement)element).Name;

        public LogElement this[int index] => BaseGet(index) as LogElement;
    }
}
