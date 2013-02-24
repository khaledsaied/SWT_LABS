using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;

namespace Demomain
{
    class Program
    {
        static void Main(string[] args)
        {
            IStackCalculator sc = new StackCalculator();

            sc.Push(12);
            sc.Pop();
            
            Console.WriteLine("There are {0} values in the stack",sc.Size);

            sc.Push(10);
            sc.Push(20);
            sc.Push(30);

            Console.WriteLine("The 3 values in the stack are: {0} {1} {2}",sc[0],sc[1],sc[2]);

            Console.WriteLine("Badaboom!");
        }
    }
}
