using System;

namespace WeighingSystem
{
    public class Weight
    {
        private uint _resolution;

        public Weight()
        {
            _resolution = 250;  // 1/4 gram per unit
        }

        public double GetResolution()
        {
            Console.WriteLine("Weight::Resolution(): Returning resolution {0}", _resolution);
            return _resolution;
        }

        public uint Read()
        {
            uint retVal = (uint) new Random().Next(0, 1024);
            Console.WriteLine("Weight::Read(): Returning read value {0}", retVal);
            return retVal;
        }
    }
}