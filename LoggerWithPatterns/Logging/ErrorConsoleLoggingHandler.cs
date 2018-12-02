using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public class ErrorConsoleLoggingHandler : ConsoleLoggingHandler
    {
        public ErrorConsoleLoggingHandler()
           : base(LogLevel.Error)
        {
        }

        protected override void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
