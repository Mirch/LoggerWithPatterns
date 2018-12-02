using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public class Logger
    {
        private ILoggingStrategy _strategy;

        public Logger(ILoggingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ILoggingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Log(string message, LogLevel logLevel = LogLevel.Message)
        {
            Log log = ConstructLog(message, logLevel);

            _strategy.Log(log);
        }

        private Log ConstructLog(string message, LogLevel level)
        {
            return new Log.LogBuilder()
                            .WithMessage(message)
                            .WithLevel(level)
                            .UseTemplate(Template.TypeWithSquareBrackets)
                            .Build();
        }
    }
}
