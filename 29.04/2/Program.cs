using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());

            while (a != 0)
            {
                s = s + 1;
                Console.WriteLine("введите число");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
