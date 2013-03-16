using System;

namespace WeighingSystem
{
    public interface IPrinter
    {
        void PrintLabel(double val);
    }

    public class StubPrinter : IPrinter
    {
        public  void PrintLabel(double val)
        {}
    }

    public class Printer
    {
        public void PrintLabel(double val)
        {
            Console.WriteLine("Printer::PrintLabel(): Label printed with value {0}", val);
        }
    }
}