using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public interface IStackCalculator
    {
        void Push(double param); // Push param on top of stack

        double Pop();            // Pop topmost value of stack and return it
                                 // Throws InvalidOperationException if the stack is empty

        void Add();            // Replace the two topmost values on the stack with their sum
                                 // Throws ArgumentException if there are less than 2 values on the stack

        void Sub();            // Replace the two topmost values on the stack with their difference. The
                                 // topmost value is subtracted from the one below.
                                 // Throws ArgumentException if there are less than 2 values on the stack

        void Mul();            // Replace the two topmost values on the stack with their sum
                                 // Throws ArgumentException if there are less than 2 values on the stack

        void Div();            // Replace the two topmost values on the stack with their sum. The topmost
                                 // value is used to divide the one below.
                                 // Throws ArgumentException if there are less than 2 values on the stack
                                 // Throws DivideByZeroException if the topmost value is 0.

        void Clear();            // Clears all content from the stack

        int Size { get; }        // Read-only property that holds the number of elements currently in the stack

        double this[int index]   // Indexer that allows a user to view (read-only) the contents of the stack
        {                        // If there are 5 values on the stack, index 0 returns the bottom-most value
            get;                 // and index 4 returns the topmost value. If the index is out of bounds
        }                        // (i.e. < 0 or >= Size()) an IndexOutOfRangeException is thrown.

        void Swap();            // Swap the two topmost values on the stack
                                // Throws InvalidOperationException if there are less than 
                                // 2 values on the stack

        void RotateUp();        // Rotate the values on the stack, so that all values move up by one, and 
                                // the topmost value moves to the bottom

        void RotateDown();      // Rotate the values on the stack, so that all values down up by one, and 
                                // the bottommost value moves to the top

    }

    public class StackCalculator : IStackCalculator
    {
        private readonly Stack<double> _stack = new Stack<double>();
 
        public void Push(double param)
        {
            _stack.Push(param);
        }

        public double Pop()
        {
            if(_stack.Count==0)
                throw new InvalidOperationException("Der er ikke noget i stacken ! Derfor kan ikke Poppes!");
           return _stack.Pop();
        }

        public void Add()
        {
            if(_stack.Count < 2)
                throw new ArgumentException();
            double topmostValue = _stack.Pop();
            double nextTopmostValue = _stack.Pop();
            double total = topmostValue + nextTopmostValue;
            _stack.Push(total);
        }

        public void Sub()
        {
            if (_stack.Count < 2)
                throw new ArgumentException();
            double total = _stack.Pop() - _stack.Pop();
            _stack.Push(total);
        }

        public void Mul()
        {
            if (_stack.Count < 2)
                throw new ArgumentException();
            double total = _stack.Pop() * _stack.Pop();
            _stack.Push(total);
        }

        public void Div()
        {
            if (_stack.Count < 2)
                throw new ArgumentException();

            double TopmostValue = _stack.Pop();
            double NextTopmostValue = _stack.Pop();

            if (TopmostValue == 0)
                throw new DivideByZeroException();

            double total = NextTopmostValue / TopmostValue;
            _stack.Push(total);
        }

        public void Clear()
        {
            //int length = this.Size;
            //for (int i = 0; i < length; i++)
            //{
            //    this.Pop();
            //}

            _stack.Clear();
        }

        public int Size
        {
            get { return _stack.Count; }
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= _stack.Count)
                    throw new IndexOutOfRangeException();
                return _stack.ElementAt(_stack.Count-index-1);
            }
        }

        public void Swap()
        {
            if (_stack.Count < 2)
                throw  new InvalidOperationException();
           
            double TopMostValue1 = _stack.Pop();
            double TopMostValue2 = _stack.Pop();
            _stack.Push(TopMostValue1);
            _stack.Push(TopMostValue2);

        }
        
        public void RotateUp()
        {
            int Size = _stack.Count();
            double[] ValueArray = new double[Size];
            _stack.CopyTo(ValueArray,0);
            _stack.Clear();
            _stack.Push(ValueArray[0]); 

            for (int i = Size-1; i > 0; i--)
                _stack.Push(ValueArray[i]);
        }
        
        public void RotateDown()
        {

            int Size = _stack.Count();
            double[] ValueArray = new double[Size];
            _stack.CopyTo(ValueArray, 0);
            _stack.Clear();
            _stack.Push(ValueArray[0]);

            for (int i = Size - 2; i > -1; i--)
                _stack.Push(ValueArray[i]);
            
            _stack.Push(ValueArray[Size-1]);
        }
    }
}
