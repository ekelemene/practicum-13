using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Задача 5. Определить статический метод int Meters (int k, int m), который принимает два целых аргумента
    /// (километры k, метры m) и возвращает количество метров. Используя этот метод, вычислить количество метров для расстояния:
    /// </summary>
    class Program
    {
        static int Meters(int k, int m)
        {
            return k * 1000 + m;
        }
        static int Input(string messege)
        {
            Console.Write(messege);
            return int.Parse(Console.ReadLine());
        }
        static void Output(int result)
        {
            Console.WriteLine($"result = {result}");
        }
        static void Main(string[] args)
        {
            int k = Input("километры = ");
            int m = Input("метры = ");
            int result = Meters(k, m);
            Output(result);
            Console.ReadKey();


        }
    }
}
