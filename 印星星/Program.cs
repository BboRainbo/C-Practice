using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 印星星
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BuildTriangle(GetIntValue("正三角形高度"));
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
        static void BuildTriangle(int height)
        {

            for (int i = 1; i <= height; i++)
            {
                string spaces = new string(' ', height - i);
                string stars = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + stars);
            }
        }
        #endregion
    }

}
