using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 印星星_巢狀
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BuildTriangle(GetIntValue("三角形高度"));
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


            for (int current_floor = 1; current_floor <= height; current_floor++)
            {
                for (int space = 0; space < (height - current_floor); space++)
                { Console.Write(' '); }
                for (int stars = 1; stars < (2 * current_floor); stars++)
                { Console.Write('*'); }
                Console.WriteLine();
            }

        }
    }
}


#endregion