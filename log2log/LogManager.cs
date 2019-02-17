using log2log.Configuration;
using log2log.LogBuilding;
using System;
using System.Collections.Generic;
using System.IO;
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
            var tempPath1 = currentLoggerSection.LogItems[0].Path;
            var tempPath2 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\");
            var tempPath3 = Path.GetDirectoryName(tempPath2 + tempPath1);
            if(!Directory.Exists(tempPath3)) Directory.CreateDirectory(tempPath3);
            path = Path.GetFullPath(tempPath2 + tempPath1);
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
