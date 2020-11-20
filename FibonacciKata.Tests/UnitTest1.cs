using NUnit.Framework;

namespace FibonacciKata.Tests
{
    public class FibonacciShould
    {

        [Test]
        public void Return1WhenPositionIs2()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(2);
            Assert.AreEqual(1,result);
        }

        [Test]
        public void Return2WhenPositionIs3()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(3);
            Assert.AreEqual(2, result);
        }

        [Test]

        public void Return3WhenPositionIs4()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(4);
            Assert.AreEqual(3,result);
        }

        [Test]
        public void Return5WhenPositionIs5()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(5);
            Assert.AreEqual(5,result);
        }

        [Test] 
        public void Return0WhenPositionIs0()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Return1WhenPositionIs1()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(1);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Return8WhenPositionIs6()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(6);
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Return610WhenPositionIs15()
        {
            var fibonacci = new Fibonacci();
            var result = fibonacci.ValueOf(15);
            Assert.AreEqual(610, result);
        }

        
    }
}