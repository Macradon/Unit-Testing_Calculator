﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        
        public static double Power(double x, double exp)
        {
            double result = x;
            for (int i = 1; exp > i; i++)
            {
                result = result * x;
            }
            return result;
        }
    }
}
