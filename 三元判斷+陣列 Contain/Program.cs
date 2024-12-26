using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元判斷_陣列_Contain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "lemon", "pineapple", "grapes" };
            while (true)
            {
                Console.WriteLine("請輸入水果名稱");
                string input = Console.ReadLine();
                bool result = fruits.Contains(input) ? false : true;
                if (!result) { Console.WriteLine("有!"); }
                else { Console.WriteLine("沒有!"); }


            }

        }

    }
}