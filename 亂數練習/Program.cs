using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 亂數練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int value = random.Next(1, 11);
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
