using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public class StreamLoggingStrategy : ILoggingStrategy
    {
        private readonly Stream _stream;
        private readonly StreamWriter _writer;

        public StreamLoggingStrategy(Stream destination)
        {
            _stream = destination;
            _writer = new StreamWriter(_stream);
        }

        public void Log(Log log)
        {
            _writer.Write(log.Content);
            _writer.Write('\n');
            _writer.Flush();
        }

    }

}

