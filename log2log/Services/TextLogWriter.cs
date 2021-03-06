﻿using log2log.Core;
using log2log.LogBuilding;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Services
{
    internal class TextLogWriter : ILogWriter
    {
        private static object lockObj = new object();
        private string path;
        public Queue<ILogData> loggerQueue { get; set; }

        /// <summary>
        /// LogFactory incapsulate path of file and logic of loger creating
        /// </summary>
        /// <param name="logFactory"></param>
        /// <param name="loggerQueue"></param>
        public TextLogWriter(string newPath)
        {
            if (File.Exists(path)) this.path = newPath;
            else
            {
                this.path = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\"), newPath);
            }
        }

        /// <summary>
        /// Write to .log file
        /// </summary>
        public bool Write()
        {
            lock(lockObj)
            {
                try
                {
                    using (var stream = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        foreach (var item in loggerQueue)
                        {
                            stream.Write(item.LogTime + " | " );
                            stream.Write(item.Level + " | ");
                            stream.Write(item.Message + " | ");
                            stream.WriteLine();
                        }
                        loggerQueue.Clear();
                    }
                    return true;
                }
                catch(Exception ex)
                {
                    Debug.Write(ex.Message);
                    return false;
                }
            }
        }

        public void Dispose()
        {
            
        }
    }
}
