using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三位一撇
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入數字");
                string NUM = Console.ReadLine();
                string output = "";
                for (int i = 0; i < (NUM.Length); i++)
                {
                    output = NUM[(NUM.Length - i) - 1] + output;
                    if ((i + 1) % 3 == 0 && !((i + 1) == NUM.Length))
                    {
                        output = "," + output;
                    }
                }
                Console.WriteLine(output);
                Console.ReadKey();
            }
        }
    }
}
