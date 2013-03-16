using System;

namespace WeighingSystem
{

    public interface IWeighingUnit
    {
        void SetUnit(uint unit);
        double GetWeight();
    }

    public class StubWeighingUnit : IWeighingUnit
    {
        public void SetUnit(uint unit)
        {
        }
        public double GetWeight()
        {
            return 0;
        } 
    }

    public class WeighingUnit : IWeighingUnit
    {
        
        public const uint UnitKg       = 0;
        public const uint UnitLb        = 1;
        public const uint UnitOunces    = 2;
        public const uint UnitGrams     = 3;

        private uint _unit;
        private Weight _weight;
        private double _weightResolution;

        public void SetUnit(uint unit)
        {
            Console.WriteLine("WeighingUnit::SetUnit(): Setting unit of measurement to {0}", unit);
            _unit = unit;

        }

        public WeighingUnit()
        {
            _weight = new Weight();
            _weightResolution = _weight.GetResolution();
        }

        public double GetWeight()
        {
            return _weightResolution*Weight2Grams(_weight.Read());
        }

        private double Weight2Grams(uint weightInMg)
        {
            switch(_unit)
            {
                case UnitKg:
                    return weightInMg * 1E-6;
                    break;

                case UnitLb:
                    return weightInMg * 2.204662262E-6;
                    break;

                case UnitOunces:
                    return weightInMg * 3.52739619E-5;

                case UnitGrams:
                    return weightInMg * 1E-3;
                    break;
                default:
                    throw new WeighingUnitException("Unit of weight not supported");

            }
        }
    }

    internal class WeighingUnitException : Exception
    {
        public WeighingUnitException(string s) : base(s)
        {
        }
    }
}