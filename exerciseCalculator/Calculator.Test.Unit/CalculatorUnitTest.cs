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

        [TestCase(5.5, 5.5, 7, 12.5, -7, 5.5)]
        [TestCase(0, 0, 3, 3, -5, -2)]
        [TestCase(10, 10, 10, 20, 10, 30)]
        public void Add_AddOverload(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Add(a), Is.EqualTo(result_a));
            Assert.That(uut.Add(b), Is.EqualTo(result_b));
            Assert.That(uut.Add(c), Is.EqualTo(result_c));
        }

        [TestCase(4.5, -4.5, 7, -11.5, -2, -9.5)]
        [TestCase(0, 0, -7, 7, 10, -3)]
        [TestCase(10, -10, 10, -20, 10, -30)]
        public void Add_SubtractOverload(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Subtract(a), Is.EqualTo(result_a));
            Assert.That(uut.Subtract(b), Is.EqualTo(result_b));
            Assert.That(uut.Subtract(c), Is.EqualTo(result_c));
        }

        [TestCase(3, 0, 6, 0, -11, 0)]
        public void Add_MultiplyOverload(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Multiply(a), Is.EqualTo(result_a));
            Assert.That(uut.Multiply(b), Is.EqualTo(result_b));
            Assert.That(uut.Multiply(c), Is.EqualTo(result_c));
        }

        [TestCase(3, 0, 6, 0, -11, 0)]
        public void Add_DivideOverload(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Multiply(a), Is.EqualTo(result_a));
            Assert.That(uut.Multiply(b), Is.EqualTo(result_b));
            Assert.That(uut.Multiply(c), Is.EqualTo(result_c));
        }

        [TestCase(4, 0, 0, 1, 11, 1)]
        public void Add_PowerOverload(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Power(a), Is.EqualTo(result_a));
            Assert.That(uut.Power(b), Is.EqualTo(result_b));
            Assert.That(uut.Power(c), Is.EqualTo(result_c));
        }

        [TestCase(8, 8, 5, 3, 7, 21)]
        [TestCase(3, 3, 5, -2, 5, -10)]
        [TestCase(-5, -5, -8, 3, 3, 9)]
        public void Add_AddSubMul(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Add(a), Is.EqualTo(result_a));
            Assert.That(uut.Subtract(b), Is.EqualTo(result_b));
            Assert.That(uut.Multiply(c), Is.EqualTo(result_c));
        }

        [TestCase(6, -6, 10, 4, 2, 2)]
        [TestCase(12, -12, 3, -9, 3, -3)]
        [TestCase(10, -10, 10, 0, 10, 0)]
        public void Add_SubAddDib(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Subtract(a), Is.EqualTo(result_a));
            Assert.That(uut.Add(b), Is.EqualTo(result_b));
            Assert.That(uut.Divide(c), Is.EqualTo(result_c));
        }

        [TestCase(6, 6, 0.5, 3, 3, 27)]
        [TestCase(-1, -1, 10, -10, 2, 100)]
        [TestCase(0.25, 0.25, 8, 2, 6, 64)]
        public void Add_AddMulPow(double a, double result_a, double b, double result_b, double c, double result_c)
        {
            Assert.That(uut.Add(a), Is.EqualTo(result_a));
            Assert.That(uut.Multiply(b), Is.EqualTo(result_b));
            Assert.That(uut.Power(c), Is.EqualTo(result_c));
        }

        [TestCase(9, 9, 5, -5)]
        [TestCase(-7, -7, 0, 0)]
        [TestCase(3, 3, -3, 3)]
        public void Add_AddClrSub(double a, double result_a, double b, double result_b)
        {
            Assert.That(uut.Add(a), Is.EqualTo(result_a));
            uut.Clear();
            Assert.That(uut.Subtract(b), Is.EqualTo(result_b));
        }
    }
}
