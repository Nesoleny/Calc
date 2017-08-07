using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EveryDay.Calc.Calculation
{
    public class Calculator
    {
        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Substr(double x, double y)
        {
            return x - y;
        }

        public double Div(double x, double y)
        {
            return y == 0 ? 0 : x / y;
        }

        public double mult(double x, double y)
        {
            return x * y;
        }

        public double sqr(double x)
        {
            return x * x;
        }

        public double sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
