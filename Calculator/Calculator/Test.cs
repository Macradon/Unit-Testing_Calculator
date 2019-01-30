using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Test
    {
        public static void test(double a, double b)
        {
            Console.WriteLine(Calculator.Add(a, b));
            Console.WriteLine(Calculator.Subtract(a, b));
            Console.WriteLine(Calculator.Multiply(a, b));
            Console.WriteLine(Calculator.Power(a, b));
        }
    }
}
