using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerWithPatterns.Logging
{
    public enum Template
    {
        TypeWithSquareBrackets,
        SimpleType,
        NoType,
    }

    public class Log
    {
        public string Content { get; private set; }
        public LogLevel Level { get; private set; }

        public class LogBuilder
        {
            private string _message;
            private LogLevel _level;
            private Template _template;

            public LogBuilder()
            {
            }

            public LogBuilder WithMessage(string message)
            {
                _message = message;
                return this;
            }

            public LogBuilder WithLevel(LogLevel level)
            {
                _level = level;
                return this;
            }

            public LogBuilder UseTemplate(Template template)
            {
                _template = template;
                return this;
            }

            public Log Build()
            {
                Log log = new Log();

                switch (_template)
                {
                    case Template.NoType:
                        break;
                    case Template.SimpleType:
                        _message = $"{_level.ToString().ToUpper()} : {_message}";
                        break;
                    case Template.TypeWithSquareBrackets:
                        _message = $"[{_level.ToString().ToUpper()}] : {_message}";
                        break;
                }

                log.Content = _message;
                log.Level = _level;

                return log;
            }

        }
    }
}
