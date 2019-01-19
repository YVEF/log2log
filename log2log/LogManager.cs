using log2log.Configuration;
using log2log.LogBuilding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log
{
    public static class LogManager
    {

        /// <summary>
        /// This is static class for instance creating
        /// </summary>
        /// <param name="logConnetionName">Log name in Web/Appconfig</param>
        /// <returns>New instance logger is ILoglog type</returns>
        public static ILoglog GetCurrentLogInstance()
        {
            ILogFactory logFactory = new LogFactory();
            return logFactory.CreateLoger();
        }
    }
}
