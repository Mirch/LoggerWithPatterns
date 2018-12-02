using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public class WarningConsoleLoggingHandler : ConsoleLoggingHandler
    {
        public WarningConsoleLoggingHandler()
            : base(LogLevel.Warning)
        {
        }

        protected override void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
