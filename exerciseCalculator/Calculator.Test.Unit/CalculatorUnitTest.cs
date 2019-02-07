using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{

    [TestFixture]
    public class CalculatorUnitTest
    {

        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [TestCase(2, 4, 6)]
        [TestCase(3, 6, 9)]
        [TestCase(14, 18, 32)]
        public void Add_AddPositiveNumbers(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(-2, -4, -6)]
        [TestCase(-3, -6, -9)]
        [TestCase(-14, -18, -32)]
        public void Add_AddNegativeNumbers(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(2, -4, -2)]
        [TestCase(-3, 6, 3)]
        [TestCase(-17, 17, 0)]
        public void Add_AddPosAndNegNumbers(double a, double b, double result)
        {
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(7, 4, 3)]
        [TestCase(6, 12, -6)]
        [TestCase(14, 14, 0)]
        public void Add_SubtractPositiveNumbers(double a, double b, double result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(-7, -4, -3)]
        [TestCase(-6, -12, 6)]
        [TestCase(-14, -14, -0)]
        public void Add_SubtractNegativeNumbers(double a, double b, double result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        [TestCase(-7, -4, -3)]
        [TestCase(-6, -12, 6)]
        [TestCase(-14, -14, -0)]
        public void Add_SubtractPosAndNegNumbers(double a, double b, double result)
        {
            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }
    }
}
