using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
        }
        static void task1()
        {
            string name, sname;
            Console.WriteLine("Введите фамилию: ");
            sname = Console.ReadLine();
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Приветствую тебя " + sname + " " + name);
        }
        static void task2()
        {
            int a, b, c;
            Console.WriteLine("\nВведите два значения");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Сумма : " + c);
        }
    }
}
