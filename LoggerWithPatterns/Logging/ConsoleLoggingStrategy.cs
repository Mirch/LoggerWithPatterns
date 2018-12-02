using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public sealed class ConsoleLoggingStrategy : ILoggingStrategy
    {
        private readonly ConsoleLoggingHandler _handler;

        private static ConsoleLoggingStrategy _instance;

        private ConsoleLoggingStrategy()
        {
            _handler = SetupLoggingHandlersChain();
        }

        public static ConsoleLoggingStrategy GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ConsoleLoggingStrategy();
            }

            return _instance;
        }

        private ConsoleLoggingHandler SetupLoggingHandlersChain()
        {
            var errorHandler = new ErrorConsoleLoggingHandler();
            var warningHandler = new WarningConsoleLoggingHandler();
            var messageHandler = new MessageConsoleLoggingHandler();

            messageHandler.SetNextHandler(warningHandler);
            warningHandler.SetNextHandler(errorHandler);

            return messageHandler;
        }

        public void Log(Log log)
        {
            _handler.Handle(log);
        }

    }
}
