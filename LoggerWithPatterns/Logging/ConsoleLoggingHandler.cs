using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public abstract class ConsoleLoggingHandler
    {
        private ConsoleLoggingHandler _nextHandler;
        protected LogLevel _logLevel;

        public ConsoleLoggingHandler(LogLevel logLevel)
        {
            _logLevel = logLevel;
        }

        public void SetNextHandler(ConsoleLoggingHandler handler)
        {
            _nextHandler = handler;
        }

        public void Handle(Log log)
        {
            if (log.Level <= _logLevel)
            {
                Log(log.Content);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(log);
            }
        }

        protected abstract void Log(string message);
    }
}
