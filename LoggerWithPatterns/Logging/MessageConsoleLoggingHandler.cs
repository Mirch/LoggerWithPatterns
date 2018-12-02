using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public class MessageConsoleLoggingHandler : ConsoleLoggingHandler
    {
        public MessageConsoleLoggingHandler()
            :base(LogLevel.Message)
        {

        }

        protected override void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
