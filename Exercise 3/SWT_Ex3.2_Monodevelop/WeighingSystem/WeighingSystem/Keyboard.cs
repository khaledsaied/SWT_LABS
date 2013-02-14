using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    public class Keyboard : LoggingObject
    {
        public Keyboard(Log log) : base(log)
        {
        }

        // Returns true if a key was pressed, in which case row/column indicates the key.
        // Returns false if no key was pressed, in which case row/column is set at 0/0.
        public bool GetNextKeypress(out uint row,out uint column) // (*) IKeyboard
        {
            row = 0;
            column = 0;
            if (DoLog)
                Logger.LogMsg(String.Format("GetNextKeypress(), row={0}/column={1}",row,column));
            return true;
        }
    }
}
