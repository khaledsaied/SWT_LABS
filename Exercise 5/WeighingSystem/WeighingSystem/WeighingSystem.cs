using System;

namespace WeighingSystem
{
    public interface IWeighingSystemFactory
    {
        void SetUnit(uint unit);
        void WeighGoods();
        IWeighingUnit createWeighingUnit();
        IPrinter createPrinter();
        ILog createLog();
    }

    public class StubWeighingSystem
    {
        void SetUnit(uint unit)
        { }
        void WeighGoods()
        { }
        //IWeighingUnit createWeighingUnit()
        //{ }
        //IPrinter createPrinter()
        //{ }
        //ILog createLog()
        //{ }
    }

    public class WeighingSystem
    {
        private IWeighingUnit _weighingUnit;
        private IPrinter _printer;
        public IPrinter Printer
        {
            private get { return _printer; }
            set { _printer = value; }
        }

        public WeighingSystem(IWeighingUnit iw)
        {
            _weighingUnit = iw;
            _printer = null;
        }

        public void SetUnit(uint unit)
        {
            Console.WriteLine("WeighingUnit::SetUnit(): Setting unit to {0}", unit);
            _weighingUnit.SetUnit(unit);
        }

        public void WeighGoods()
        {
            var curWeight = _weighingUnit.GetWeight();
            _printer.PrintLabel(Math.Round(curWeight, 3));  // Print a label with the weight on it
        }
    }
}
