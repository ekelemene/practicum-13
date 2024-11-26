using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /// <summary>
    /// Задача 3. Найти s=min(a, b) + min(c, d), используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата
    /// </summary>
    class Program
    {
        static int Input(string messege)
        {
            Console.WriteLine(messege);
            return  int.Parse(Console.ReadLine());
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
            int x = Input("x=");
            int y = Input("y=");
            int z = Input("z=");
            int c = Input("c=");
            int result = Min(x, y) + Min(z, c);
            Output(result);
            Console.ReadKey();
        }
    }
}
