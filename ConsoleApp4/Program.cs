using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Задача 2. Найти минимальную величину их трех целых переменных a, b, c с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
    /// </summary>
    class Program
    {
        static int Input(string messege)
        {
            Console.Write(messege);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int a,int b)
        {
            return a < b ? a : b;
        }
        static void Output(int result)
        {
          
            Console.WriteLine($"result = {result}");
        }
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int result = Min(Min(a, b),c);
            Output(result);
            Console.ReadLine();

        }
    }
}
