using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    public class WeighingController : LoggingObject
    {
        private WeighingUnit _weighingUnit;
        private Printer _printer;
        private Display _display;
        private Keyboard _keyboard;

        public WeighingController() : base(new Log("log.txt",false))
        {
            _weighingUnit = new WeighingUnit(Logger,new Weight());
            _printer = new Printer(Logger);
            _display = new Display(Logger);
            _keyboard = new Keyboard(Logger);
        }

    }
}
