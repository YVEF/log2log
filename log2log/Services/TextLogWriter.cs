using log2log.Core;
using log2log.LogBuilding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Services
{
    public class TextLogWriter : ILogWriter
    {
        private static object lockObj = new object();
        private string path;
        private Queue<ILogData> loggerQueue;

        /// <summary>
        /// LogFactory incapsulate path of file and logic of loger creating
        /// </summary>
        /// <param name="logFactory"></param>
        /// <param name="loggerQueue"></param>
        public TextLogWriter(ILogFactory logFactory, Queue<ILogData> loggerQueue)
        {
            this.logFactory = logFactory;
            this.loggerQueue = loggerQueue;
        }

        /// <summary>
        /// Write to .log file
        /// </summary>
        public bool Write()
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    foreach (var item in loggerQueue)
                    {
                        stream.Write(item.dateTime);
                        stream.Write(item.Level);
                        stream.Write(item.Message);
                    }
                    loggerQueue.Clear();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
