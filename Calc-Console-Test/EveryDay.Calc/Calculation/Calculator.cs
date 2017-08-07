using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EveryDay.Calc.Calculation
{
    public class Calculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Div(int x, int y)
        {
            return y == 0 ? 0 : x / y;
        }

    }
}
