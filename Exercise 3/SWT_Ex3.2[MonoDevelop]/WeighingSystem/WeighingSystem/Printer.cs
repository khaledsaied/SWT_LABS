using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    public interface IPrinter
    {
        void PrintLabel(string text);
    }

    public class Printer : LoggingObject, IPrinter
    {
        public Printer(Log log) : base(log)
        {
        }

        public void PrintLabel(string text)     // (*) IPrinter
        {
            if (DoLog)
                Logger.LogMsg(String.Format("Printing label \"{0}\"",text));
        }
    }
}
