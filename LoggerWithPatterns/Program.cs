using LoggerWithPatterns.Logging;
using System;
using System.IO;

namespace LoggerWithPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLoggingExample();

            //StreamLoggingExample();
        }

        static void ConsoleLoggingExample()
        {
            ILoggingStrategy strategy = ConsoleLoggingStrategy.GetInstance();

            Logger logger = new Logger(strategy);

            logger.Log("Logging a message.");
            logger.Log("Logging a warning.", LogLevel.Warning);
            logger.Log("Logging an error.", LogLevel.Error);

            Console.Read();
        }

        static void StreamLoggingExample()
        {
            Stream stream = new MemoryStream();
            ILoggingStrategy strategy = new StreamLoggingStrategy(stream);

            Logger logger = new Logger(strategy);

            logger.Log("Logging a message.");
            logger.Log("Logging a warning.", LogLevel.Warning);
            logger.Log("Logging an error.", LogLevel.Error);

            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);

            string value = reader.ReadToEnd();

            Console.WriteLine(value);

            Console.Read();
        }

    }
}
