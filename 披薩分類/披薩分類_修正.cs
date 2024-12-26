using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 披薩分類
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                double temp = GetDoubleValue("溫度(度C)");


                if (125 < temp || temp < 120)
                {
                    Console.WriteLine("Bad pizza!");
                    continue;
                }

                double wet = GetDoubleValue("濕度");

                if (7 < wet || wet < 5)
                {
                    Console.WriteLine("Bad Pizza!");
                    continue;
                }

                Console.WriteLine("Good pizza!");
                Console.WriteLine("請按任意鍵繼續");
                Console.ReadLine();

            }



        }
        static double GetDoubleValue(string name)
        {
            double value = 0;
            while (true)
            {
                Console.WriteLine($"請輸入{name}");
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"您輸入的{name}為{value}");
                    break;
                }
                else { Console.WriteLine("輸入格式有誤，請再試一次(僅能為 double)"); }
            }
            return value;
        }
    }
}
