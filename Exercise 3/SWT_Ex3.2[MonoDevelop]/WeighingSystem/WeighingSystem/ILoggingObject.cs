using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    interface ILoggingObject
    {
        bool DoLog
        {
            get; set;
        }

        Log Logger { get; }
    }
}
