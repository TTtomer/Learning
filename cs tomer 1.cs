
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            int num;
            int num2;
            Random b = new Random();
            num = b.Next(0, 101);
            num2 = b.Next(0, 101);
            while (a)
            {
                
                Console.Write("{0} + {1} = ", num, num2);
                a = num + num2 != int.Parse(Console.ReadLine());

            }
            Console.WriteLine(num + num2);

        }
    }
}