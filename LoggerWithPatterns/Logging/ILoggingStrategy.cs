using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public interface ILoggingStrategy
    {
        void Log(Log log);
    }
}
