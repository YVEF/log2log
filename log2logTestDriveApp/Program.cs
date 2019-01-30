using log2log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2logTestDriveApp
{
    class Program
    {
        public static ILoglog log = LogManager.GetCurrentLogInstance();

        static void Main(string[] args)
        {
            log.Info("Start a program");

            log.Info("Continue the program");
           
            Console.Read();
            
        }
    }
}
