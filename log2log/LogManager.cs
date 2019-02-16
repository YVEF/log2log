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
        private static string path;
        static LogManager()
        {
            var currentLoggerSection = (LogConfigSection)LogConfigHelper.GetConfigFromDomain().GetSection("log2log");
            path = currentLoggerSection.LogItems[0].Path;
        }

        /// <summary>
        /// This is static class for instance creating
        /// </summary>
        /// <param name="logConnetionName">Log name in Web/Appconfig</param>
        /// <returns>New instance logger is ILoglog type</returns>
        public static ILoggerClient GetCurrentLogInstance()
        {
            var logFactory = new LogFactory(new Loglog(path));

            return logFactory.CreateLogWriter().GetLoggerClient();
        }
    }
}
