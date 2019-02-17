using log2log;
using log2log.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2logTestDriveApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerClient logger = LogManager.GetCurrentLogInstance();
            for(int i=0; i<100; i++)
                logger.Info("abrakadabra");

            Console.Read();
        }
    }
}
