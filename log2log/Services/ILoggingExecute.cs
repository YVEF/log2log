﻿using System.Collections.Generic;



namespace log2log.Services
{
    internal interface ILoggingExecute
    {
        void AddLog(ILogData data);
    }
}