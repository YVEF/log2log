using log2log.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Core
{
    struct LogData : ILogData
    {
        public DateTime dateTime => DateTime.Now;
        public string Level { get; set; }
        public string Message { get; set; }
    }
}
