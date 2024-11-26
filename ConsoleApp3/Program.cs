using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /// <summary>
    /// //Задача 1. Найти минимальную величину из двух целых переменных a, b, используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
         static int Input(string messege)
        {
            Console.Write(messege);
            return int.Parse(Console.ReadLine());
        }
         public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        static void Output(int result)
        {
            Console.WriteLine($"result = {result}");
        }
        static void Main(string[] args)
        {
            int x = Input("x=");
            int y = Input("y=");
            int result = Min(x, y);
            Output(result);
            Console.ReadKey();
        }
    }
}
