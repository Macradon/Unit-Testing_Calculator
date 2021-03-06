﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                return 0;
            }
            else
                return a / b;
        }

        public double Power(double x, double exp)
        {
            result = Math.Pow(x, exp);
            return result;
        }

        private double result = 0;

        public double Add(double addend)
        {
            result = Accumulator + addend;
            return result;
        }

        public double Subtract(double subtractor)
        {
            result = Accumulator - subtractor;
            return result;
        }

        public double Multiply(double multiplier)
        {
            result = Accumulator * multiplier;
            return result;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                return result;
            }
            else
            {
                result = Accumulator / divisor;
                return result;
            }
        }

        public double Power(double exponent)
        {
            result = Math.Pow(Accumulator, exponent);
            return result;
        }

        public void Clear()
        {
            result = 0;
        }

        public double Accumulator
        {
            get
            {
                return result;
            }
            private set
            {
                result = value;
            }
        }
    }
}
