using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeighingSystem
{
    public enum WeightUnit
    {
        WeightUnitKg,
        WeightUnitLb,
        WeightUnitOunces,
        WeightUnitGrams
    }

    public class WeighingUnit : LoggingObject
    {
        private Weight _weight;

        public WeighingUnit(Log log,Weight weight) : base(log)
        {
            _weight = weight;
        }

        public double GetWeight()               // (*) IWeighingUnit
        {
            double returnvalue = 100.0;
            // Illustrates use of log flag
            if (DoLog)
                Logger.LogMsg(String.Format("GetWeight() = {0:F2}",returnvalue));
            return returnvalue;
        }

        public void SetUnit(WeightUnit unit)    // (*) IWeighingUnit
        {
        }

        public uint GetUnit()                   // (*) IWeighingUnit
        {
            return 0;
        }
    }
}
