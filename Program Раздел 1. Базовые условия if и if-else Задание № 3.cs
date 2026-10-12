using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Первое число: ");
            if (!int.TryParse(Console.ReadLine(), out int a)) { Console.WriteLine("Ошибка."); return; }
            Console.Write("Второе число: ");
            if (!int.TryParse(Console.ReadLine(), out int b)) { Console.WriteLine("Ошибка."); return; }

            if (a > b)
                Console.WriteLine($"Наибольшее: {a}");
            else if (b > a)
                Console.WriteLine($"Наибольшее: {b}");
            else
                Console.WriteLine("Числа равны.");
        }
    }
}