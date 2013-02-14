using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WeighingSystem
{
    public class Log
    {
        private StreamWriter _writer;
        
        public Log(string filename,bool truncatelog)
        {
            if (truncatelog && File.Exists(filename))
                File.Delete(filename);
            _writer = new StreamWriter(filename,true);
        }
        
        
        public void LogMsg(string msg) // (*) ILog
        {
            var now = DateTime.Now;
            _writer.WriteLine("{0:D4}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2} > {6}",
                now.Year,now.Month,now.Day,now.Hour,now.Minute,now.Second,msg);
            _writer.Flush();
        }
    }
}
