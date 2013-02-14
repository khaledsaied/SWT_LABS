using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    public interface IDisplay
    {
        uint Rows { get; }
        uint Columns { get; }
        void GetCursor(out uint x, out uint y);
        void MoveCursor(uint x, uint y);
        void Write(string text);
        void EraseAll(); 

    }

    public class Display : LoggingObject,IDisplay
    {
        private uint _rows, _columns;

        public Display(Log log) : base(log)
        {
            _rows = 20;
            _columns = 60;
        }

        public uint Rows                                // (*) IDisplay
        {
            get { return _rows; }
        }

        public uint Columns                             // (*) IDisplay
        {
            get { return _columns; }
        }
        public void GetCursor(out uint x,out uint y)    // (*) IDisplay
        {
            x = 0;
            y = 0;
        }

        public void MoveCursor(uint x,uint y)           // (*) IDisplay
        {
        }

        public void Write(string text)                  // (*) IDisplay
        {
        }

        public void EraseAll()                          // (*) IDisplay
        {
            if (DoLog)
                Logger.LogMsg("Display EraseAll()");
        }
    }
}
