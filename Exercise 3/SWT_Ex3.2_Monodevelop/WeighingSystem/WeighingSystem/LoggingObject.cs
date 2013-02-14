using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    public class LoggingObject : ILoggingObject
    {
        private bool _dolog = false;
        private Log _log;

        public LoggingObject(Log log)
        {
            _log = log;
        }

        public bool DoLog
        {
            get { return _dolog; }
            set { _dolog = value; }
        }

        public Log Logger
        {
            get { return _log; }
        }
    }
}
