using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 印菱形
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BuildDiamond(GetIntValue("菱形高度"));
            }

        }

        #region Functions
        static int GetIntValue(string name)
        {
            int value = 0;
            while (true)
            {
                Console.WriteLine($"請輸入{name}");
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"您輸入的{name}為{value}");
                    break;
                }
                else { Console.WriteLine("輸入格式有誤，請再試一次(僅能為 int)"); }

            }
            return value;
        }
        static void BuildDiamond(int height)
        {
            int upper = height % 2 == 0 ? (height / 2) : (height / 2 + 1);
            int lower = height - upper;
            for (int i = 1; i <= upper; i++)
            {
                string spaces = new string(' ', upper - i);
                string stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars);
            }
            for (int i = 1; i <= lower; i++)
            {
                string spaces = new string(' ', (i - 1) + height % 2);
                string stars = new string('*', (2 * lower) - (2 * i) + 1);
                Console.WriteLine(spaces + stars);
            }
        }
    }
}

#endregion
