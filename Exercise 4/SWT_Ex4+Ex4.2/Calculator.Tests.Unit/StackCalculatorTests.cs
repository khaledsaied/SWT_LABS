using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Calculator;

namespace Calculator.Tests.Unit
{
    [TestFixture]
    public class StackCalculatorTests : AssertionHelper
    {
        [Test]
        public void Push_PushingValue_ValuePushed()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            Expect(calc.Size,Is.EqualTo(1));
        }

        [Test]
        public void Pop_PopsValue_ValuePopped()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            calc.Push(200);
            calc.Push(100);
            calc.Pop();
            Expect(calc.Size, Is.EqualTo(2));
        }

        [Test]
        public void Pop_InvalidMessage_PopsValueInEmptyStack_ThrowsException()
        {
            var calc = new StackCalculator();
            Exception e = Assert.Throws<InvalidOperationException> ( () => calc.Pop() );
        }

        [Test]
        public void Add_AddingValues_ValuesAdded()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            calc.Push(200);
            calc.Add();
            Expect(calc.Pop(), Is.EqualTo(300));
        }

        [Test]
        public void Add_AddingWhereStackCountIsLessThanTwo_ThrowsException()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            Exception e = Assert.Throws<ArgumentException> ( () => calc.Add() );
        }

        [Test]
        public void Sub_SubstractingValues_ValuesSubstracted()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            calc.Push(200);
            calc.Sub();
            Expect(calc.Pop(), Is.EqualTo(200-100));
        }

        [Test]
        public void Sub_SubstractingWhereStackCountIsLessThanTwo_ThrowsException()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            Exception e = Assert.Throws<ArgumentException>(() => calc.Sub());
        }

        [Test]
        public void Mul_MultiplyingValues_ValuesMultiplied()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            calc.Push(200);
            calc.Mul();
            Expect(calc.Pop(), Is.EqualTo(200*100));
        }

        [Test]
        public void Mul_MultiplyingWhereStackCountIsLessThanTwo_ThrowsException()
        {
            var calc = new StackCalculator();
            calc.Push(200);
            Exception e = Assert.Throws<ArgumentException>(() => calc.Mul());
        }

        [Test]
        public void Div_DividingValues_ValuesDivided()
        {
            var calc = new StackCalculator();
            calc.Push(200);
            calc.Push(100);
            calc.Div();
            Expect(calc.Pop(), Is.EqualTo(200 / 100));
        }

        [Test]
        public void Div_DivideByZero_ThrowsException()
        {
            var calc = new StackCalculator();
            calc.Push(20);
            calc.Push(0);
            Exception e = Assert.Throws<DivideByZeroException>(() => calc.Div());
        }

        [Test]
        public void Div_DividingWhereStackCountIsLessThanTwo_ThrowsException()
        {
            var calc = new StackCalculator();
            calc.Push(200);
            Exception e = Assert.Throws<ArgumentException>(() => calc.Div());
        }

        [Test]
        public void Clear_ClearingData_DataCleared()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            calc.Clear();
            Expect(calc.Size, Is.EqualTo(0) );
        }

        [Test]
        public void Index_ReturningValue_ValueReturned()
        {
            var calc = new StackCalculator();
            calc.Push(10);
            Expect(calc[0], Is.EqualTo(10));
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Index_IndexOutOfRange_ThrowsException()
        {
            var calc = new StackCalculator();
            calc.Push(200);
            var i = calc[10];
        }

        [Test]
        public void Swap_SwapValues_ValuesSwaped()
        {
            var calc = new StackCalculator();
            calc.Push(100);
            calc.Push(200);
            calc.Swap();
            Expect(calc.Pop(), Is.EqualTo(100));
        }

        [Test]
        public void Swap_InvalidOperation_ThrowsException()
        {
            var calc = new StackCalculator();
            //calc.Push(10);
            Exception e = Assert.Throws<InvalidOperationException>(() => calc.Swap());
        }

        [Test]
        public void RotateUp_MoveUpValues_ValuesMovedUp()
        {
            var calc = new StackCalculator();
            calc.Push(20);
            calc.Push(30);
            calc.Push(40);
            calc.RotateUp();
            Assert.AreEqual(calc.Pop(),30);
       }

        [Test]
        public void RotateDown_MoveDownValues_ValuesMovedDown()
        {
            var calc = new StackCalculator();
            
            calc.Push(20);
            calc.Push(30);
            calc.Push(40);
            calc.Push(50);
            calc.RotateDown();
            Assert.AreEqual(calc.Pop(),20);
        }

    }
}
