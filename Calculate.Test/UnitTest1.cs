using NewCalcolator;
using System;
using static NewCalcolator.Operations;

namespace Calculate.Test
{
    public class AdditionFunctionTest
    {
        [Fact]
        public void AdditionPositivTest()
        {
            var result = Operations.Addition(6, 8);

            Assert.Equal(14, result);

        }
        [Fact]
        public void AdditionNegitiveTest()
        {
            
            Assert.Equal(-6, Addition(-2, -4));
        }
        [Fact]
        public void AdditionNegitiveAndPositiveTest()
        {
          
            Assert.Equal(-6, Addition(-8,2));
        }
        [Fact]
        public void AdditionArrayPositiveTest()
        {
            var result = Operations.Addition(new int[] { 4, 7, 8 });
            Assert.Equal(19, result);
        }
        [Fact]
        public void AdditionArrayNegitiveTest()
        {
            var result = Operations.Addition(new int[] { 4, -7, -4 });
            Assert.Equal(-7, result);
        }
    }

    public class SubtractFunctionTest
    {
        [Fact]
        public void SubtractPositiveTest()
        {
            var result = Operations.Subtract(9, 8);
            Assert.Equal(result, 1);
        }
        [Fact]
        public void SubtractNegitivTest()
        {
            var result = Operations.Subtract(-9, -2);
            Assert.Equal(-7, result);
        }
        [Fact]
        public void SubtractNegitivPositiveTest()
        {
            var result = Operations.Subtract(9, -2);
            Assert.Equal(11, result);
        }
        [Fact]
        public void SubtractArrayPositiveTest()
        {
            var result = Operations.Subtract(new int[] { 5, 8, 9 });
            Assert.Equal(-12, result);
        }
        [Fact]
        public void SubtractArrayNegitiveTest()
        {
            var result = Operations.Subtract(new int[] { -5, -8, -4 });
            Assert.Equal(7, result);
        }

    }

    public class MultiplyFunctionTest
    {
        [Fact]
        public void MultiplyPositiveTest()
        {
            Assert.Equal(72, Operations.Multiply(9, 8));
        }
        [Fact]
        public void MultiplyNegitiveTest()
        {
            Assert.Equal(72, Operations.Multiply(-9, -8));
        }
        [Fact]
        public void MultiplyNegetiveAndPositiveTest()
        {
            Assert.Equal(-72, Operations.Multiply(9, -8));
        }
    }

    public class DivideFunctionTest
    {
        [Fact]
        public void DividePositiveTest()
        {
            Assert.Equal(2, Divide(8, 4));
        }
        [Fact]
        public void DivideNegitiveTest()
        {
            Assert.Equal((decimal)2.8, Divide(-14, -5));
        }
        [Fact]
        public void DividByZeroSeconedNumberTest()
        {
            Assert.IsNotType<decimal>(Divide(8, 0));
            //var result = new DivideFunctionTest();
            //void act() => result.ToString("");
            //var caughtException = Assert.Throws<DivideByZeroException>(() => result.DividByZeroSeconedNumberTest());

            //Assert.Equal("Not valid operation", caughtException.Message);
            ////Assert.Throws<DivideByZeroException>(new DivideByZero (() => DivideByZero()));
        }
        

        [Fact]
        public void DividByZeroFirstNumberTest()
        {
            Assert.Equal(0, Divide(0, 1));
        }
       
    } 
}