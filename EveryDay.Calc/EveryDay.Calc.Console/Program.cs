using EveryDay.Calc.Calculation;
using SConsole = System.Console;

namespace EveryDay.Calc.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var oper = args[0];
            
            var x = Str2Int(args[1]);

            double y = 0;
            try
            {
                y = Str2Int(args[2]);
            }
            catch {
                SConsole.WriteLine("Не указано значени переменной y, по умолчанию 0");
            }

            var calc = new Calculator();

            double result = 0;

            if (oper.ToLower() == "sum")
            {
                result = calc.Sum(x, y);
            }
            else if (oper.ToLower() == "div")
            {
                result = calc.Div(x, y);
            }
            else if (oper.ToLower() == "mult")
            {
                result = calc.mult(x, y);
            }
            else if (oper.ToLower() == "substr")
            {
                result = calc.Substr(x, y);
            }
            else if (oper.ToLower() == "sqr")
            {
                result = calc.sqr(x);
            }
            else if (oper.ToLower() == "sqrt")
            {
                result = calc.sqrt(x);
            }
            else
            {
                SConsole.WriteLine("Нет такой операции");
            }
            
            SConsole.WriteLine(result.ToString());

            SConsole.ReadKey();
        }


        private static double Str2Int(string str)
        {
            double result;

            if(!double.TryParse(str, out result)){
                SConsole.WriteLine("Не удалось преобразовать \"{0}\" в число", str);
            }
            return result;
        }
    }
}
