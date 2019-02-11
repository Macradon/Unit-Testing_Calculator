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

        [TestCase(4, 1, 4)]
        [TestCase(0, 12, 0)]
        [TestCase(10, 10, 100)]
        public void Add_MultiplyPositiveNumbers(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(-4, -1, 4)]
        [TestCase(-0, -12, 0)]
        [TestCase(-10, -10, 100)]
        public void Add_MultiplyNegativeNumbers(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(-4, 4, -16)]
        [TestCase(-6, 4, -24)]
        [TestCase(-10, 10, -100)]
        public void Add_MultiplyPosAndNegNumbers(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(4, 1, 4)]
        [TestCase(0, 12, 0)]
        [TestCase(13, 13, 1)]
        public void Add_DividePositiveNumbers(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(-4, -1, 4)]
        [TestCase(-0, -12, 0)]
        [TestCase(-13, -13, 1)]
        public void Add_DivideNegativeNumbers(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(-16, 4, -4)]
        [TestCase(6, -4, -1.5)]
        [TestCase(-99, 99, -1)]
        public void Add_DividePosAndNegNumbers(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(7, 1, 7)]
        [TestCase(0, 14, 0)]
        [TestCase(13, 0, 1)]
        public void Add_PowerPositiveNumbers(double a, double b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

        [TestCase(-5, 2, 25)]
        [TestCase(-3, 3, -27)]
        [TestCase(-13, 1, -13)]
        public void Add_PowerNegativeNumbers(double a, double b, double result)
        {
            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }
    }
}
