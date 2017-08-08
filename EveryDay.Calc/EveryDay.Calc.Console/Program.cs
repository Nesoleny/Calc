using EveryDay.Calc.Calculation;
using EveryDay.Calc.Calculation.Interfaces;
using EveryDay.Calc.Calculation.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using SConsole = System.Console;
using System.IO;

namespace EveryDay.Calc.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<IOperation> operationList = LoadOperations();
            try
            {
                do
                {
                    SConsole.Clear();
                    showCalcDescription(operationList);
                    showDialog(operationList);
                }
                while (SConsole.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                SConsole.WriteLine(ex.Message);
                SConsole.ReadKey();
            }

        }

        private static void showDialog(IEnumerable<IOperation> operationList)
        {
            //todo: обработки исключений

            SConsole.WriteLine("Введите имя команды");
            string oper = SConsole.ReadLine();

            SConsole.WriteLine("Введите первое число");
            double x = Double.Parse(SConsole.ReadLine());

            SConsole.WriteLine("Введите второе число");
            double y = Double.Parse(SConsole.ReadLine());

            var calc = new Calculator(operationList);

            var result = calc.Calc(oper, new[] { x, y });

            SConsole.WriteLine(result.ToString());

            SConsole.WriteLine("Операция выполнена успешно, для выполнения ещё одной нажмите любую клавишу, для завершения нажмите Esc");

        }

        private static void showCalcDescription(IEnumerable<IOperation>  operationList)
        {
            SConsole.WriteLine("Список доступных операций:");
            foreach (var item in operationList)
            {
                SConsole.WriteLine(item.Description + " - " + item.Name);
            }
        }

        private static IEnumerable<IOperation> LoadOperations()
        {
            var opers = new List<IOperation>();

            var typeOperation = typeof(IOperation);

            // найти все dll, которые находятся рядом с нашим exe
            var dlls = Directory.GetFiles(Environment.CurrentDirectory, "*.dll");

            // перебираем
            foreach (var dll in dlls)
            {
                // загружаем сборку из файла
                var assembly = Assembly.LoadFrom(dll);
                // получаем типы/классы/интерфейсы из сброрки
                var types = assembly.GetTypes();

                // перебираем типы
                foreach (var type in types)
                {
                    var interfaces = type.GetInterfaces();
                    // если тип реализует наш интерфейс 
                    if (interfaces.Contains(typeOperation))
                    {
                        // пытаемся создать экземпляр
                        var instance = Activator.CreateInstance(type) as IOperation;
                        if (instance != null)
                        {
                            // добавляем в список операций
                            opers.Add(instance);
                        }
                    }
                }
            }

            return opers;
        }

    }
}
