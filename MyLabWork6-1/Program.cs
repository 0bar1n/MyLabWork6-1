using System;

namespace MyLabWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a, b, sum;
            Console.WriteLine("a="); //просим пользователя ввести число
            a = Convert.ToInt32(Console.ReadLine()); //задание переменной целого типа
            Console.WriteLine("b="); //просим пользователя ввести число
            b = Convert.ToInt32(Console.ReadLine()); //задание переменной целого типа
            sum = a + b; // задание переменной целого типа по формуле
            Console.WriteLine($"{a}+{b}={sum}"); //вывод на экран суммы чисел
        }
    }
}
