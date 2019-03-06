using log2log.Configuration;
using log2log.LogBuilding;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log
{
    /// <summary>
    /// Logger manager reads .config and implements all logger dependecies
    /// </summary>
    public static class LogManager
    {
        private static string path;
        private static ConnectionStringSettings connectionSettings;
        private static LogFactory logFactory;

        static LogManager()
        {
            var currentLoggerSection = (LogConfigSection)LogConfigHelper.GetConfigFromDomain().GetSection("log2log");
            var tempPath1 = currentLoggerSection.LogItems[0].Path;
            if (currentLoggerSection.LogItems[0].toDataBase)
            {
                var provName = currentLoggerSection.LogItems[0].dbConnectionName;
                connectionSettings = LogConfigHelper.GetConfigFromDomain().ConnectionStrings.ConnectionStrings[provName];
            }
                
            var tempPath2 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\");
            var tempPath3 = Path.GetDirectoryName(tempPath2 + tempPath1);
            if(!Directory.Exists(tempPath3)) Directory.CreateDirectory(tempPath3);
            path = Path.GetFullPath(tempPath2 + tempPath1);
        }

        /// <summary>
        /// The method creates a logger client for the calling project. App/Web.config file must be correct.
        /// </summary>
        /// <returns></returns>
        public static ILoggerClient GetCurrentLogInstance()
        {
            
            if (connectionSettings != null) logFactory = new LogFactory(new Loglog(path, connectionSettings));
            else logFactory = new LogFactory(new Loglog(path));

            return logFactory.CreateLogWriter().GetLoggerClient();
        }
    }
}
