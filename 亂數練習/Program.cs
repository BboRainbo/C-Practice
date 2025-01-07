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
                Console.WriteLine(Guid.NewGuid());
                //Random random = new Random(Guid.NewGuid().GetHashCode());
                //int value = random.Next(1, 11);
                //Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
