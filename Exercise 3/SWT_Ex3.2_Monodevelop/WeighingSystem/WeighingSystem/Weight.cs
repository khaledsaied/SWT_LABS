using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    public class Weight
    {
        public Weight()
        {
        }

        public uint Read()              // (*) IWeight
        {
            return 0;
        }

        public double GetResolution()   // (*) IWeight
        {
            return 0.0;
        }
    }
}
